using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Sexo : Netcore.ActivoFijo.Entity.Sexo
    {
        public static async Task<List<Sexo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Sexo> query = (from q in Query.GetSexos(context) select q);

            List<Sexo> list = await query.ToList<Sexo>();

            return list;
        }
    }
}