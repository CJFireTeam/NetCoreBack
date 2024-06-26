using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class PostTitulo : Netcore.ActivoFijo.Entity.PostTitulo
    {
        public static async Task<List<PostTitulo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.PostTitulo> query = (from q in Query.GetPostTitulos(context) select q);

            List<PostTitulo> list = await query.ToList<PostTitulo>();

            return list;
        }
    }
}