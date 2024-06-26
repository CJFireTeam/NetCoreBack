using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoLocacion : Netcore.ActivoFijo.Persistent.TipoLocacion
    {
        public static async Task<List<TipoLocacion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context, string id)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoLocacion> query = (from q in Query.GetTipoLocaciones(context, id) select q);

            List<TipoLocacion> list = await query.ToList<TipoLocacion>();

            return list;
        }
        public static async Task<TipoLocacion> Insert(Netcore.ActivoFijo.Model.Context context, Guid empresa, string nombre)
        {

            TipoLocacion newElement = new TipoLocacion();
            newElement.EmpresaId = empresa;
            newElement.Nombre = nombre;
            await newElement.Save(context);
            await context.SaveChangesAsync();
            return newElement;
        }
    }
}