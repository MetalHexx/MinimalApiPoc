﻿using MinimalApi.Features.CustomExamples._common;
using MinimalApi.Features.Examples._common;

namespace MinimalApi.Features.CustomExamples.CustomPut
{
    public class CustomPutRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    public class CustomPutRequestValidator : AbstractValidator<CustomPutRequest>
    {
        public CustomPutRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
        }
    }
    public class CustomPutResponse : RadResponse<ExampleDto> { }
}