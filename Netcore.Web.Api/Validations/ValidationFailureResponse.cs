﻿using FluentValidation.Results;

namespace Netcore.Web.Api.Validations
{
    public class ValidationFailureResponse
    {
        public IEnumerable<string> Errors { get; set; } = Enumerable.Empty<string>();
    }

    public static class ValidationFailureMapper
    {
        public static ValidationFailureResponse ToResponse(this IEnumerable<ValidationFailure> validationFailures)
        {
            return new ValidationFailureResponse
            {
                Errors = validationFailures.Select(x => x.ErrorMessage)
            };
        }
    }
}