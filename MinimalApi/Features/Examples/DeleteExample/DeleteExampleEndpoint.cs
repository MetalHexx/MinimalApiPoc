﻿using MinimalApi.Domain.Examples;

namespace MinimalApi.Features.Examples.DeleteExample
{
    public class DeleteExampleEndpoint() : RadEndpoint<DeleteExampleRequest, DeleteExampleResponse>
    {
        public override void Configure()
        {
            Delete("/examples/{id}")
                .Produces<DeleteExampleResponse>(StatusCodes.Status200OK)
                .WithDocument(tag: Constants.ExamplesTag, desc: "Delete an example.");
        }

        public async override Task<IResult> Handle(DeleteExampleRequest r, CancellationToken ct)
        {
            await Service<IExampleService>().DeleteExample(r.Id);
            Response.Message = "Example deleted successfully";

            return Ok(Response);
        }
    }
}
