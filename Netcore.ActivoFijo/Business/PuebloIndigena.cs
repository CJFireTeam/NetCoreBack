using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class PuebloIndigena : Netcore.ActivoFijo.Entity.PuebloIndigena
    {
        public static async Task<List<PuebloIndigena>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.PuebloIndigena> query = (from q in Query.GetPuebloIndigenas(context) select q);

            List<PuebloIndigena> list = await query.ToList<PuebloIndigena>();

            return list;
        }
    }
}