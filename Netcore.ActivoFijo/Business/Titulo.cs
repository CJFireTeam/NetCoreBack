using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Titulo : Netcore.ActivoFijo.Entity.Titulo
    {
        public static async Task<List<Titulo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Titulo> query = (from q in Query.GetTitulos(context) select q);

            List<Titulo> list = await query.ToList<Titulo>();

            return list;
        }
    }
}