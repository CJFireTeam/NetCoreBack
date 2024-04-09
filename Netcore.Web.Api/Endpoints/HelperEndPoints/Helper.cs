using Microsoft.AspNetCore.Authorization;

namespace Netcore.Web.Api.Endpoints.HelperEndPoints
{
    public class Helper : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/GetToken/{rut}", [AllowAnonymous] (Netcore.ActivoFijo.Model.Context context, string rut) =>
            {
                try
                {
                    int rutBodyInt;

                    string rutBody = rut.Replace(".", string.Empty);

                    rutBody = rutBody.Replace("-", string.Empty);

                    string rutDigit = rutBody.Substring(rutBody.Length - 1, 1);

                    rutBody = rutBody.Substring(0, rutBody.Length - 1);

                    if (int.TryParse(rutBody, out rutBodyInt))
                    {
                        Netcore.ActivoFijo.Business.Persona person = Netcore.ActivoFijo.Business.Persona.Get(context, rutBodyInt, rutDigit);

                        string accessToken = Netcore.ActivoFijo.Business.AccessToken.GenerateAccessToken(person);

                        return Results.Ok(accessToken);
                    }
                    else
                    {
                        throw new Exception("RUT ERRONEO");
                    }
                }
                catch
                {
                    return Results.Problem("ERROR");
                }
            }).Produces<string>(StatusCodes.Status200OK)
              .Produces<string>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}