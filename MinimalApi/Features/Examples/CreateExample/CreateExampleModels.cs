﻿using MinimalApi.Features.Examples._common.Dtos;

namespace MinimalApi.Features.Examples.CreateExample
{
    public class CreateExampleRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    public class CreateExampleValidator : AbstractValidator<CreateExampleRequest> 
    {
        public CreateExampleValidator()
        {
            RuleFor(x => x!.FirstName).NotEmpty()
                .WithMessage("Cannot be empty");

            RuleFor(x => x!.LastName).NotEmpty()
                .WithMessage("Cannot be empty");
        }
    }
    
    public class CreateExampleResponse : EndpointResponse<ExampleDto> { }    
}
