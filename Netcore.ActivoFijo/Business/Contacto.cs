using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Contacto : Netcore.ActivoFijo.Persistent.Contacto
    {
        public static async Task<List<Contacto>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Contacto> query = (from q in Query.GetContactos(context) select q);

            List<Contacto> list = await query.ToList<Contacto>();

            return list;
        }
    }
}