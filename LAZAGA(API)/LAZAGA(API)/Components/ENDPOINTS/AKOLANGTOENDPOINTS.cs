using LAZAGA_API_.Components.ENDPOINTS;

namespace LAZAGA_API_.Components.ENDPOINTS;

    public static class AKOLANGTOENDPOINTS
    {
        public static void MapAKO(this WebApplication app)
        {
        app.MapGet("/api/AKO", () =>
        {
            var me = new Models.AKOLANGTO
            {
                Dog = "Nig",
                Breed = "Labrador",
                Price = 800
            };
            return Results.Ok(me);

        });
            
            
        }

    }   