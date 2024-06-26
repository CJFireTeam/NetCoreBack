using Microsoft.EntityFrameworkCore;
using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Almacen : Netcore.ActivoFijo.Persistent.Almacen
    {
        public static async Task<List<Almacen>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Almacen> query = (from q in Query.GetAlmacenes(context) select q);

            List<Almacen> list = await query.ToList<Almacen>();

            return list;
        }
        public static async Task<List<Almacen>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context, int page, int perPage, Guid guid)
        {
            IQueryable<Netcore.ActivoFijo.Model.Almacen> query = (from q in Query.GetAlmacenesPaginated(context, page, perPage, guid)
            .Include(Almacen => Almacen.Locacions)
                                                                  select q);
            List<Almacen> list = await query.ToList<Almacen>();

            return list;
        }
        public static async Task<List<Almacen>> GetOne(Netcore.ActivoFijo.Model.Context context, Guid guid)
        {
            IQueryable<Netcore.ActivoFijo.Model.Almacen> query = (from q in Query.GetOneAlmacenes(context, guid)
            .Include(a => a.TipoAlmacen)
            .Include(a => a.Locacions)
            select q);
            List<Almacen> list = await query.ToList<Almacen>();

            return list;
        }
        public static int GetCount(Netcore.ActivoFijo.Model.Context context,Guid guid)
        {
            return context.Almacens.Where(e => e.BodegaId == guid).Count();
        }
        public static async Task<Almacen> Insert(
            Netcore.ActivoFijo.Model.Context context,
            Guid empresaId,
            Guid bodegaId,
            Guid centroCostoId,
            Guid tipoAlmacenId,
            string? codigo,
            string nombre,
            Guid? id
            )
        {
            try
            {
                Almacen newElement = new Almacen();
                newElement.EmpresaId = empresaId;
                newElement.BodegaId = bodegaId;
                if (id != null)
                {
                    newElement.Id = (Guid)id;
                }
                else
                {
                    newElement.Id = Guid.NewGuid();
                }
                newElement.TipoAlmacenId = tipoAlmacenId;
                newElement.CentroCostoId = centroCostoId;
                newElement.Codigo = codigo;
                newElement.Nombre = nombre;
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