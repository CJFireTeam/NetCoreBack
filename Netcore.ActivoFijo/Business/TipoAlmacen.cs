using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoAlmacen : Netcore.ActivoFijo.Persistent.TipoAlmacen
    {
        public static async Task<List<TipoAlmacen>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoAlmacen> query = (from q in Query.GetTipoAlmacenes(context) select q);

            List<TipoAlmacen> list = await query.ToList<TipoAlmacen>();

            return list;
        }
        public static async Task<TipoAlmacen> Insert(Netcore.ActivoFijo.Model.Context context, string codigo, string nombre)
        {

            TipoAlmacen newElement = new TipoAlmacen();
            newElement.Codigo = codigo;
            newElement.Nombre = nombre;
            await newElement.Save(context);
            await context.SaveChangesAsync();
            return newElement;
        }

        public static async Task<TipoAlmacen> Update(Netcore.ActivoFijo.Model.Context context, string id, string codigo, string nombre)
        {
            Guid guidUuid = Guid.Parse(id);

            TipoAlmacen newElement = new TipoAlmacen();
            newElement.Id = guidUuid;
            newElement.Codigo = codigo;
            newElement.Nombre = nombre;
            await newElement.Save(context);
            await context.SaveChangesAsync();
            return newElement;
        }
        public static async Task<TipoAlmacen?> FindOne(Netcore.ActivoFijo.Model.Context context, string id)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoAlmacen> query = Query.GetOneTipoAlmacenes(context, id);

            List<TipoAlmacen> list = await query.ToList<TipoAlmacen>();
            if (list.Count == 0) throw new("Id no encontrado");
            return list[0];
        }
    }
}