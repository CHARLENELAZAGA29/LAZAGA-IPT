

using LAZAGA_PERSONALINFO_PROJECT.Components.Model;

namespace LAZAGA_PERSONALINFO_PROJECT.Components.Endpoints
{
    public static class MyInfoEnpoint
    {
        public static void MapEndpoints(this WebApplication app)
        {
            // GET Student
            app.MapGet("/api/get", () =>
            {
                try
                {
                    var data = new MyFN()
                    {
                        FirstN = "Charlene Dane",
                      
                    };
                    return Results.Ok(data);
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapGet("/api/get/MD", () =>
            {
                try
                {
                    var data = new MyMN()
                    {
                        MiddleN = "Ponce",

                    };
                    return Results.Ok(data);
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);

                }
            });

            app.MapGet("/api/get/LN", () =>
            {
                try
                {
                    var data = new MyLN()
                    {
                        LastN = "Lazaga",

                    };
                    return Results.Ok(data);
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapGet("/api/get/course", () =>
            {
                try
                {
                    var data = new Mycourse()
                    {
                        Course = "BSIT"
                    };

                    return Results.Ok(data);
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapGet("/api/get/Year", () =>
            {
                try
                {
                    var data = new MyYear()
                    {
                        year = "3rd Year",

                    };
                    return Results.Ok(data);
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapGet("/api/get/MyBirthday", () =>
            {
                try
                {
                    var data = new MyBirthday()
                    {
                        birthday = "July 29,2005"


                    };
                    return Results.Ok(data);
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapGet("/api/get/MyAge", () =>
            {
                try
                {
                    var data = new Myage()
                    {
                        Age = "21 years old"


                    };
                    return Results.Ok(data);
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });




        }
    }
}