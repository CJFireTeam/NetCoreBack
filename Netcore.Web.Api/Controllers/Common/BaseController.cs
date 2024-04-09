using Mapster;
using Microsoft.EntityFrameworkCore;
using Netcore.ActivoFijo.Business;
using Netcore.ActivoFijo.Model;

namespace Netcore.Web.Api.Controllers.Common
{
    public abstract class BaseController
    {
        private HttpContext _httpContext;
        private Context _context;

        public BaseController(HttpContext httpContext, Context context)
        {
            this._httpContext = httpContext;

            this._context = context;

            this._context.Database.SetCommandTimeout(3600);
        }

        public Netcore.ActivoFijo.Business.Persona CurrentPerson()
        {
            string rutPerson = this._httpContext.User.Claims.First(claim => claim.Type == Netcore.ActivoFijo.Enum.EnumClaims.Rut.ToString()).Value;

            int rutBodyInt;

            string rutBody = rutPerson.Replace(".", string.Empty);

            rutBody = rutBody.Replace("-", string.Empty);

            string rutDigit = rutBody.Substring(rutBody.Length - 1, 1);

            rutBody = rutBody.Substring(0, rutBody.Length - 1);

            if (int.TryParse(rutBody, out rutBodyInt))
            {
                this._context.ConfigureAwait(true);

                return Netcore.ActivoFijo.Business.Persona.Get(this._context, rutBodyInt, rutDigit);
            }
            else
            {
                return null;
            }
        }
        public string CurrentConnectionString
        {
            get
            {
                string connectionString = this._httpContext.User.Claims.First(claim => claim.Type == Netcore.ActivoFijo.Enum.EnumClaims.ConnectionString.ToString()).Value;

                return connectionString;
            }
        }
    }
}