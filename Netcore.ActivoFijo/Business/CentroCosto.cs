using Netcore.Abstraction.PartialOverload;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Business
{
    public class CentroCosto : Netcore.ActivoFijo.Persistent.CentroCosto
    {
        public static async Task<List<CentroCosto>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.CentroCosto> query = (from q in Query.GetCentroCostos(context) select q);

            List<CentroCosto> list = await query.ToList<CentroCosto>();

            return list;
        }
        public static async Task<List<CentroCosto>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context, int page, int perPage)
        {
            IQueryable<Netcore.ActivoFijo.Model.CentroCosto> query = (from q in Query.GetCentroCostosPaginated(context, page, perPage) select q);

            List<CentroCosto> list = await query.ToList<CentroCosto>();

            return list;
        }
        public static async Task<List<CentroCosto>> GetOne(Netcore.ActivoFijo.Model.Context context, Guid id)
        {
            IQueryable<Netcore.ActivoFijo.Model.CentroCosto> query =  (from q in Query.GetCentroCostosOne(context, id)
            .Include(CC => CC.Empresa)
            .Include(CC => CC.Administrador)
            .Include(CC => CC.Bodegas)
            
            select q);
            List<CentroCosto> list = await query.ToList<CentroCosto>();
            

            return list;
        }
        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.CentroCostos.Count();
        }
        public static async Task<CentroCosto> Insert(
           Netcore.ActivoFijo.Model.Context context,
           Guid empresaId,
           Guid? centroCostoId,
           Guid? administradorId,
           string nombre,
           string? sigla,
           int areaGeograficaCodigo,
           int? tipoEstablecimientoSaludCodigo,
           short? regionCodigo,
           short? ciudadCodigo,
           short? comunaCodigo,
           string? email,
           string? direccion,
           int? telefono1,
           int? telefono2,
           int? fax,
           int? celular,
           string? codigoContabilidad,
           bool libroRemuneraciones,
           string? rutaReporte,
           Guid? departamentoId,
           Guid? unidadId,
           string? codigoPrevired,
           int? codigoGesparvu,
           bool administracionCentral,
           string? codigoDIPRES,
           bool contabilizacion,
           Guid? Id
           )
        {
            try
            {
                CentroCosto newElement = new CentroCosto();
                newElement.EmpresaId = empresaId;
                newElement.CentroCostoId = centroCostoId;
                newElement.AdministradorId = administradorId;
                newElement.Nombre = nombre;
                newElement.Sigla = sigla;
                newElement.AreaGeograficaCodigo = areaGeograficaCodigo;
                newElement.TipoEstablecimientoSaludCodigo = tipoEstablecimientoSaludCodigo;
                if (tipoEstablecimientoSaludCodigo != null) newElement.TipoEstablecimientoSaludCodigo = (short)tipoEstablecimientoSaludCodigo;
                if (regionCodigo != null) newElement.RegionCodigo = (short)regionCodigo;
                if (ciudadCodigo != null) newElement.CiudadCodigo = (short)ciudadCodigo;
                if (comunaCodigo != null) newElement.ComunaCodigo = (short)comunaCodigo;
                newElement.Email = email;
                newElement.Direccion = direccion;
                newElement.Telefono1 = telefono1;
                newElement.Telefono2 = telefono2;
                newElement.Fax = fax;
                newElement.Celular = celular;
                newElement.CodigoContabilidad = codigoContabilidad;
                newElement.LibroRemuneraciones = libroRemuneraciones;
                newElement.RutaReporte = rutaReporte;
                newElement.DepartamentoId = departamentoId;
                newElement.UnidadId = unidadId;
                newElement.CodigoPrevired = codigoPrevired;
                newElement.CodigoGesparvu = codigoGesparvu;
                newElement.AdministracionCentral = administracionCentral;
                newElement.CodigoDipres = codigoDIPRES;
                newElement.Contabilizacion = contabilizacion;
                if (Id != null) newElement.Id = (Guid)Id;
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