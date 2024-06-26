using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class FormaPago : Netcore.ActivoFijo.Entity.FormaPago
    {
        public static async Task<List<FormaPago>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.FormaPago> query = (from q in Query.GetFormaPagos(context) select q);

            List<FormaPago> list = await query.ToList<FormaPago>();

            return list;
        }
    }
}