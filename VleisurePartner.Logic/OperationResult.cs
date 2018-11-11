using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using Newtonsoft.Json;

namespace VleisurePartner.Logic
{
    public class OperationResult
    {
        public virtual bool IsSuccessful => Status == OperationStatus.Successful;
        public IEnumerable<string> ErrorMessages { get; set; }
        public OperationStatus Status { get; }

        /// <summary>
        /// Creates an OperationResult with the specified status.
        /// It is intended that a successful status does not have any messages, and an unsuccessful status may have messages.
        /// This is also the constructor used to deserialise from JSON (as decorated with the JsonConstructor attribute).
        /// </summary>
        /// <param name="status">The status.</param>
        /// <param name="errorMessages">The error messages.</param>
        [JsonConstructor]
        public OperationResult(OperationStatus status, params string[] errorMessages)
        {
            Status = status;
            ErrorMessages = errorMessages;
        }

        /// <summary>
        /// Run the next operation if the current OperationResult is successful. Otherwise the current OperationResult is returned.
        /// </summary>
        /// <param name="nextOperation">The next operation to run if the current OperationResult is successful.</param>
        /// <returns>The OperationResult of the next operation if the current is successful. Otherwise returns the current.</returns>
        public OperationResult Then(Func<OperationResult, OperationResult> nextOperation)
        {
            if (IsSuccessful)
            {
                return nextOperation(this);
            }

            return this;
        }

        /// <summary>
        /// Run the next operation if the current OperationResult is successful. Otherwise the current OperationResult is returned.
        /// </summary>
        /// <param name="nextOperation">The next operation to run if the current OperationResult is successful.</param>
        /// <returns>The OperationResult of the next operation if the current is successful. Otherwise returns the current.</returns>
        public OperationResult<TNext> Then<TNext>(Func<OperationResult, OperationResult<TNext>> nextOperation)
        {
            if (IsSuccessful)
            {
                return nextOperation(this);
            }

            return new OperationResult<TNext>(Status, ErrorMessages.ToArray());
        }

        public enum OperationStatus
        {
            Successful,
            GeneralError,
            NotFound,
            InvalidArguments,
            Unauthorized,
            FailedValidation
        }
    }

    public class OperationResult<TSuccessData> : OperationResult
    {
        public TSuccessData SuccessData { get; set; }

        /// <summary>
        /// Creates a successful OperationResult with the specified data.
        /// </summary>
        /// <param name="successData">The success data.</param>
        public OperationResult(TSuccessData successData) : base(OperationStatus.Successful)
        {
            SuccessData = successData;
        }

        /// <summary>
        /// Creates an OperationResult with the specified status.
        /// It is intended that a successful status does not have any messages, and an unsuccessful status may have messages.
        /// This is also the constructor used to deserialise from JSON (as decorated with the JsonConstructor attribute).
        /// </summary>
        /// <param name="status">The status.</param>
        /// <param name="errorMessages">The error messages.</param>
        [JsonConstructor]
        public OperationResult(OperationStatus status, params string[] errorMessages) : base(status, errorMessages)
        {
        }

        /// <summary>
        /// Creates an OperationResult with the specified errors from validation failure ErrorMessage property.
        /// </summary>
        /// <param name="errors">The status.</param>
        public OperationResult(IEnumerable<ValidationFailure> errors) : base(OperationStatus.FailedValidation,
            errors.Select(err => err.ErrorMessage).ToArray())
        {
        }

        /// <summary>
        /// Run the next operation if the current OperationResult is successful. Otherwise the current OperationResult is returned.
        /// </summary>
        /// <typeparam name="TNext">The generic type of the next operation's success data.</typeparam>
        /// <param name="nextOperation">The next operation to run if the current OperationResult is successful.</param>
        /// <returns>The OperationResult of the next operation if the current is successful. Otherwise returns the current.</returns>
        public OperationResult<TNext> Then<TNext>(Func<OperationResult<TSuccessData>, OperationResult<TNext>> nextOperation)
        {
            if (IsSuccessful)
            {
                return nextOperation(this);
            }

            return new OperationResult<TNext>(Status, ErrorMessages.ToArray());
        }

        /// <summary>
        /// Run the next operation if the current OperationResult is successful. Otherwise the current OperationResult is returned.
        /// </summary>
        /// <param name="nextOperation">The next operation to run if the current OperationResult is successful.</param>
        /// <returns>The OperationResult of the next operation if the current is successful. Otherwise returns the current.</returns>
        public OperationResult Then(Func<OperationResult<TSuccessData>, OperationResult> nextOperation)
        {
            if (IsSuccessful)
            {
                return nextOperation(this);
            }

            return new OperationResult(Status, ErrorMessages.ToArray());
        }
    }

    public class ConcurrentOperationResult<TSuccessData> : OperationResult<TSuccessData>
    {
        public byte[] RowStamp { get; }

        public ConcurrentOperationResult(TSuccessData successData, byte[] rowStamp)
            : base(successData)
        {
            RowStamp = rowStamp;
        }

        public ConcurrentOperationResult(TSuccessData successData) : base(successData)
        {
        }

        public ConcurrentOperationResult(OperationStatus status, params string[] errorMessages)
            : base(status, errorMessages)
        {
        }

        public ConcurrentOperationResult(IEnumerable<ValidationFailure> errors)
            : base(errors)
        {
        }
    }
}