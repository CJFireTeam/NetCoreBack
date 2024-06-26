using Netcore.Abstraction.PartialOverload;
using Microsoft.EntityFrameworkCore;

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
        public static async Task<List<Empresa>> GetOne(Netcore.ActivoFijo.Model.Context context, Guid id)
        {
            IQueryable<Netcore.ActivoFijo.Model.Empresa> query =  (from q in Query.GetEmpresasOne(context, id)select q).Include(Empresa => Empresa.CentroCostos);
            List<Empresa> list = await query.ToList<Empresa>();
            return list;
        }
        
        public static async Task<List<Empresa>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context, int page, int perPage)
        {
            IQueryable<Netcore.ActivoFijo.Model.Empresa> query = (from q in Query.GetEmpresasPaginated(context, page, perPage)
            .Include(Empresa => Empresa.CentroCostos)
            .Include(Empresa => Empresa.GerenteRrhh)
            .Include(Empresa => Empresa.Administrador)
                                                                  select q);

            List<Empresa> list = await query.ToList<Empresa>();

            return list;
        }
        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.Empresas.Count();
        }
        public static async Task<Empresa> GetAsync(Netcore.ActivoFijo.Model.Context context, Guid EmpresaId)
        {
            Netcore.ActivoFijo.Model.Empresa? query = await Query.GetEmpresas(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Empresa>(x => x.Id == EmpresaId);
            Empresa dato = query.SingleOrDefault<Empresa>();
            return dato;
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

        public static bool ExistByRut(Netcore.ActivoFijo.Model.Context context, int rutCuerpo, string rutDigit)
        {
            return context.Empresas.Where(e => e.RutCuerpo == rutCuerpo && e.RutDigito == rutDigit).Any();
        }

        public static bool ExistById(Netcore.ActivoFijo.Model.Context context, Guid id)
        {
            return context.Empresas.Where(e => e.Id == id).Any();
        }

        public static async Task<Empresa> Estado(Netcore.ActivoFijo.Model.Context context, Guid id)
        {
            try
            {
                Netcore.ActivoFijo.Model.Empresa? query = await Query.GetEmpresas(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Empresa>(x => x.Id == id);

                Empresa? newElement = query.SingleOrDefault<Empresa>();

                newElement.Id = id;
                newElement.Bloqueada = !newElement.Bloqueada; 
                await newElement.Save(context);
                await context.SaveChangesAsync();
                return newElement;
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public static async Task<Empresa> Update(
            Netcore.ActivoFijo.Model.Context context,
            Guid id,
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
                Netcore.ActivoFijo.Model.Empresa? query = await Query.GetEmpresas(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Empresa>(x => x.Id == id);
                Empresa? newElement = query.SingleOrDefault<Empresa>();

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
                newElement.Id=id;


                await newElement.Save(context);
                await context.SaveChangesAsync();
                return newElement;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }






    }
}