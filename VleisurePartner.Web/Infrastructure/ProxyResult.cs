using System.Web.Mvc;
using System.Collections.Generic;
using FluentValidation.Results;
using VleisurePartner.Logic;

namespace VleisurePartner.Web.Infrastructure
{
    public class ProxyResult : JsonResult
    {
        protected static readonly Dictionary<OperationResult.OperationStatus, string> OperationMessageResult = new Dictionary<OperationResult.OperationStatus, string>
        {
            { OperationResult.OperationStatus.Successful, "Operation successful" },
            { OperationResult.OperationStatus.NotFound, "Object cannot be found in the database" },
            { OperationResult.OperationStatus.GeneralError, "One or more fields failed domain validation" },
            { OperationResult.OperationStatus.InvalidArguments, "An invalid argument was encountered" },
            { OperationResult.OperationStatus.Unauthorized, "Unauthorized: Access is denied due to invalid credentials" },
            { OperationResult.OperationStatus.FailedValidation, "One or more fields failed domain validation" }
        };

        public ProxyResult()
        {
            JsonRequestBehavior = JsonRequestBehavior.AllowGet;
        }

        public ProxyResult(OperationResult data) : this()
        {
            Data = data;
        }

        /// <summary>
        /// Creates a ProxyResult with a successful OperationResult.
        /// </summary>
        /// <param name="successData">The data to associate with a successful OperationResult.</param>
        /// <returns>The ProxyResult with a successful OperationResult.</returns>
        public static ProxyResult Success()
        {
            return new ProxyResult(new OperationResult(OperationResult.OperationStatus.Successful));
        }

        /// <summary>
        /// Creates a ProxyResult with a failed OperationResult.
        /// </summary>
        /// <param name="failedStatus">The failed OperationStatus.</param>
        /// <param name="errorMessages">Optional error messages.</param>
        /// <returns>The ProxyResult with a failed OperationResult.</returns>
        public static ProxyResult Fail(OperationResult.OperationStatus failedStatus, params string[] errorMessages)
        {
            return new ProxyResult(new OperationResult(failedStatus, errorMessages));
        }

        /// <summary>
        /// Create a ProxyResult with failed validation results
        /// </summary>
        /// <param name="validationResult"></param>
        /// <returns></returns>
        public static ProxyResult Fail(IList<ValidationFailure> errors)
        {
            var errorMessages = new List<string>();

            foreach (var error in errors)
            {
                errorMessages.Add(string.Format("{0}: {1}", error.PropertyName, error.ErrorMessage));
            }

            return new ProxyResult(new OperationResult(OperationResult.OperationStatus.FailedValidation, errorMessages.ToArray()));
        }

        /// <summary>
        /// Create a ProxyResult with returned error message based on operation status
        /// </summary>
        /// <param name="failedStatus"></param>
        /// <param name="resultDictionary"></param>
        /// <returns></returns>
        public static ProxyResult Fail(OperationResult.OperationStatus failedStatus, Dictionary<OperationResult.OperationStatus, string> resultDictionary = null)
        {
            resultDictionary = resultDictionary ?? OperationMessageResult;
            var message = resultDictionary[failedStatus];
            var errorMessages = new List<string>
            {
                message
            };

            return new ProxyResult(new OperationResult(failedStatus, errorMessages.ToArray()));
        }
    }

    public class ProxyResult<T> : ProxyResult
    {
        /// <summary>
        /// Creates a ProxyResult with a successful OperationResult.
        /// </summary>
        /// <param name="successData">The data to associate with a successful OperationResult.</param>
        /// <returns>The ProxyResult with a successful OperationResult.</returns>
        public static ProxyResult<T> Success(T successData)
        {
            return new ProxyResult<T>(successData);
        }

        /// <summary>
        /// Creates a ProxyResult with a failed OperationResult.
        /// </summary>
        /// <param name="failedStatus">The failed OperationStatus.</param>
        /// <param name="errorMessages">Optional error messages.</param>
        /// <returns>The ProxyResult with a failed OperationResult.</returns>
        public new static ProxyResult<T> Fail(OperationResult.OperationStatus failedStatus, params string[] errorMessages)
        {
            return new ProxyResult<T>(new OperationResult<T>(failedStatus, errorMessages));
        }

        /// <summary>
        /// Creates a ProxyResult with a successful OperationResult.
        /// </summary>
        /// <param name="successData">The data to associate with a successful OperationResult.</param>
        private ProxyResult(T successData) : base()
        {
            Data = new OperationResult<T>(successData);
        }

        /// <summary>
        /// Creates a ProxyResult with the specified OperationResult.
        /// </summary>
        /// <param name="operationResult">The OperationResult to create the ProxyResult from.</param>
        public ProxyResult(OperationResult<T> operationResult) : base()
        {
            Data = operationResult;
        }

        /// <summary>
        /// Create a ProxyResult with failed validation results
        /// </summary>
        /// <param name="validationResult"></param>
        /// <returns></returns>
        public new static ProxyResult<T> Fail(IList<ValidationFailure> errors)
        {
            var errorMessages = new List<string>();

            foreach (var error in errors)
            {
                errorMessages.Add(string.Format("{0}: {1}", error.PropertyName, error.ErrorMessage));
            }

            return new ProxyResult<T>(new OperationResult<T>(OperationResult.OperationStatus.FailedValidation, errorMessages.ToArray()));
        }

        /// <summary>
        /// Create a ProxyResult with returned error message based on operation status
        /// </summary>
        /// <param name="failedStatus"></param>
        /// <param name="resultDictionary"></param>
        /// <returns></returns>
        public new static ProxyResult<T> Fail(OperationResult.OperationStatus failedStatus, Dictionary<OperationResult.OperationStatus, string> resultDictionary = null)
        {
            resultDictionary = resultDictionary ?? OperationMessageResult;
            var message = resultDictionary[failedStatus];
            var errorMessages = new List<string>
            {
                message
            };

            return new ProxyResult<T>(new OperationResult<T>(failedStatus, errorMessages.ToArray()));
        }
    }
}
