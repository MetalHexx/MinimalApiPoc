﻿using MinimalApi.Domain.Examples;

namespace MinimalApi.Features.Examples.GetExamples
{
    public class GetExamplesEndpoint() : RadEndpointWithoutRequest<GetExamplesResponse, GetExamplesMapper>
    {
        public override void Configure()
        {
            Get("/examples")
                .Produces<GetExamplesResponse>(StatusCodes.Status200OK)
                .WithDocument(tag: Constants.ExamplesTag, desc: "Create a new example.");
        }

        public override async Task<IResult> Handle(CancellationToken c)
        {
            Logger.Log(LogLevel.Information, "This is an example log message.");
            var examples = await Service<IExampleService>().GetExamples();
            Response = Map.FromEntity(examples);
            Response.Message = "Examples retrieved successfully";

            return Ok(Response);
        }
    }
}
