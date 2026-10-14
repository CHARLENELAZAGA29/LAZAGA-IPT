using LazagaAPI.Components.Database;
using LazagaAPI.Components.Models;
using LazagaAPI.Components.Endpoints;
namespace LazagaAPI.Components.Endpoints
{
    public static class Endpoints
    {
        public static void MapEndpoints(this WebApplication app )
        {
            app.MapGet("/api/get", () =>
            {
                return Results.Ok(fakeDatabase.student);
            });

            app.MapPost("/api/post", (myModel modelPost) =>
            {
                fakeDatabase.student = modelPost;
                return Results.Ok("Successfully Posted");
            })
            .DisableAntiforgery();
        }
    }
}