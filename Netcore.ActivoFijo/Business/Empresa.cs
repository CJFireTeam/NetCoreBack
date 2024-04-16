using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Empresa : Netcore.ActivoFijo.Persistent.Empresa
    {
        public static async Task<List<Empresa>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Empresa> query = (from q in Query.GetEmpresas(context) select q);

            List<Empresa> list = await query.ToList<Empresa>();

            return list;
        }

        public static async Task<Empresa> Insert(
            Netcore.ActivoFijo.Model.Context context,
            int rutBody,
            string rutDigit,
            string razonSocial,
            int tipoAdministracionCodigo,
            bool bloqueada,
            short? regionEmpresa,
            short? ciudadCodigo,
            short? comunaCodigo,
            int? actividadEconomicaPrincipalCodigo,
            int? sectorActividadEconomicaCodigo,
            int? actividadEconomicaCodigo,
            string? giro,
            string? direccion,
            string? email,
            string? paginaWeb,
            int? telefono1,
            int? telefono2,
            int? fax,
            int? celular,
            Guid? administradorId,
            Guid? gerenteRRHHId,
            string? rutaReporte,
            string? pieFirmaLiquidacion,
            string? url
            )
        {
            try
            {
                Empresa newElement = new Empresa();
                newElement.RutCuerpo = rutBody;
                newElement.RutDigito = rutDigit;
                newElement.RazonSocial = razonSocial;
                newElement.TipoAdministracionCodigo = tipoAdministracionCodigo;
                newElement.Bloqueada = bloqueada;
                if (regionEmpresa != null) newElement.RegionCodigo = (short)regionEmpresa;
                if (ciudadCodigo != null) newElement.CiudadCodigo = (short)ciudadCodigo;
                if (comunaCodigo != null) newElement.ComunaCodigo = (short)comunaCodigo;
                newElement.ActividadEconomicaPrincipalCodigo = actividadEconomicaPrincipalCodigo;
                newElement.SectorActividadEconomicaCodigo = sectorActividadEconomicaCodigo;
                newElement.ActividadEconomicaCodigo = actividadEconomicaCodigo;
                newElement.Giro = giro;
                newElement.Direccion = direccion;
                newElement.Email = email;
                newElement.PaginaWeb = paginaWeb;
                newElement.Telefono1 = telefono1;
                newElement.Telefono2 = telefono2;
                newElement.Fax = fax;
                newElement.Celular = celular;
                newElement.AdministradorId = administradorId;
                newElement.GerenteRrhhid = gerenteRRHHId;
                newElement.RutaReporte = rutaReporte;
                newElement.PieFirmaLiquidacion = pieFirmaLiquidacion;
                newElement.Url = url;


                await newElement.Save(context);
                await context.SaveChangesAsync();
                return newElement;
            }
            catch (System.Exception e)
            {

                throw;
            }

        }
    }
}