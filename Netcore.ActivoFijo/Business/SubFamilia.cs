using Netcore.Abstraction.PartialOverload;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Business
{
    public class SubFamilia : Netcore.ActivoFijo.Persistent.SubFamilia
    {
        public static async Task<List<SubFamilia>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.SubFamilium> query = (from q in Query.GetSubFamilias(context) select q);

            List<SubFamilia> list = await query.ToList<SubFamilia>();

            return list;
        }
        public static async Task<List<SubFamilia>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context,Guid id, int page, int perPage)
        {
            IQueryable<Netcore.ActivoFijo.Model.SubFamilium> query = (from q in Query.GetSubFamiliasPaginated(context,id, page, perPage) select q);

            List<SubFamilia> list = await query.ToList<SubFamilia>();

            return list;
        }
        public static async Task<List<SubFamilia>> GetOne(Netcore.ActivoFijo.Model.Context context, Guid id)
        {
            IQueryable<Netcore.ActivoFijo.Model.SubFamilium> query =  (from q in Query.GetSubFamiliasOne(context, id)
            .Include(SF => SF.Empresa)
            select q);
            List<SubFamilia> list = await query.ToList<SubFamilia>();
            

            return list;
        }
        public static int GetCount(Netcore.ActivoFijo.Model.Context context,Guid id)
        {
            return context.SubFamilia.Where(e => e.FamiliaId == id).Count();
        }
        public static async Task<SubFamilia> Insert(
           Netcore.ActivoFijo.Model.Context context,
           Guid empresaId,
           int anoNumero,
           Guid id,
           int codigo,
           Guid familiaId,
           Guid? cuentaId,
           Guid? cuentaObligacionId,
           string nombre,
           string? Descripcion,
           Boolean Eliminado
           )
        {
            try
            {
                SubFamilia newElement = new SubFamilia();
                newElement.EmpresaId = empresaId;
                newElement.AnoNumero = anoNumero;
                newElement.Id = id;
                newElement.Codigo = codigo;
                newElement.FamiliaId = familiaId;
                newElement.CuentaId = cuentaId;
                newElement.CuentaObligacionId = cuentaObligacionId;
                newElement.Nombre = nombre;
                newElement.Descripcion = Descripcion;
                newElement.Eliminado = Eliminado;
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