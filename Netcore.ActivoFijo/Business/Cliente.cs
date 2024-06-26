using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Cliente : Netcore.ActivoFijo.Persistent.Cliente
    {
        public static async Task<List<Cliente>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Cliente> query = (from q in Query.GetClientes(context) select q);

            List<Cliente> list = await query.ToList<Cliente>();

            return list;
        }
    }
}