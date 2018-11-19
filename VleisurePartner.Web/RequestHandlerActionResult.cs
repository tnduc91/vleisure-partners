using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace VleisurePartner.Web
{
    /// <summary>
    /// The main purpose of this class is to remove the generic typing on the enum. Otherwise, TViewModel will be part of the qualified name and usage becomes unwieldy.
    /// </summary>
    public abstract class RequestHandlerActionResult : ActionResult
    {
        public enum FailureResponse
        {
            BadRequest,
            NotFound,
            InternalServerError
        }

        public abstract ActionResult GetExecutingActionResult();
    }

    public class RequestHandlerActionResult<TModel> : RequestHandlerActionResult
    {
        private readonly FailureResponse _failureResponse;
        private readonly string[] _messages;

        private Func<TModel, ActionResult> _onSuccess = model => throw new NotImplementedException("No success function defined.");
        private Func<IEnumerable<string>, ActionResult> _onBadRequest = message => new HttpStatusCodeResult(HttpStatusCode.BadRequest, string.Join("\n", message));
        private Func<IEnumerable<string>, ActionResult> _onNotFound = message => new HttpStatusCodeResult(HttpStatusCode.NotFound, string.Join("\n", message));
        private Func<IEnumerable<string>, ActionResult> _onInternalServerError = message => new HttpStatusCodeResult(HttpStatusCode.InternalServerError, string.Join("\n", message));

        private readonly TModel _model;

        private RequestHandlerActionResult(TModel model)
        {
            _model = model;
        }

        public static RequestHandlerActionResult<TModel> Success(TModel model)
        {
            return new RequestHandlerActionResult<TModel>(model);
        }

        private RequestHandlerActionResult(FailureResponse failureResponse, params string[] messages)
        {
            _failureResponse = failureResponse;
            _messages = messages;
        }

        public static RequestHandlerActionResult<TModel> Fail(FailureResponse failureResponse, params string[] message)
        {
            return new RequestHandlerActionResult<TModel>(failureResponse, message);
        }

        public RequestHandlerActionResult<TModel> OnSuccess(Func<TModel, ActionResult> onSuccess)
        {
            _onSuccess = onSuccess;
            return this;
        }

        public RequestHandlerActionResult<TModel> OnBadRequest(Func<IEnumerable<string>, ActionResult> onBadRequest)
        {
            _onBadRequest = onBadRequest;
            return this;
        }

        public RequestHandlerActionResult<TModel> OnNotFound(Func<IEnumerable<string>, ActionResult> onNotFound)
        {
            _onNotFound = onNotFound;
            return this;
        }

        public RequestHandlerActionResult<TModel> OnInternalServerError(Func<IEnumerable<string>, ActionResult> onInternalServerError)
        {
            _onInternalServerError = onInternalServerError;
            return this;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            GetExecutingActionResult().ExecuteResult(context);
        }

        public override ActionResult GetExecutingActionResult()
        {
            if (_model != null)
            {
                return _onSuccess(_model);
            }

            switch (_failureResponse)
            {
                case FailureResponse.BadRequest:
                    return _onBadRequest(_messages);
                case FailureResponse.NotFound:
                    return _onNotFound(_messages);
                case FailureResponse.InternalServerError:
                    return _onInternalServerError(_messages);

                default:
                    throw new NotImplementedException($"Unrecognised failure response: {_failureResponse}.");
            }
        }
    }
}