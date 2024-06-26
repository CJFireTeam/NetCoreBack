using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Cuenta : Netcore.ActivoFijo.Persistent.Cuenta
    {
        public static async Task<List<Cuenta>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Cuentum> query = (from q in Query.GetCuentas(context) select q);

            List<Cuenta> list = await query.ToList<Cuenta>();

            return list;
        }

        public static async Task<List<Cuenta>> GetAllAsyncCuenta(Netcore.ActivoFijo.Model.Context context,Guid id)
        {
            IQueryable<Netcore.ActivoFijo.Model.Cuentum> query = (from q in Query.GetCuentums(context,id) select q);

            List<Cuenta> list = await query.ToList<Cuenta>();

            return list;
        }



    }
}