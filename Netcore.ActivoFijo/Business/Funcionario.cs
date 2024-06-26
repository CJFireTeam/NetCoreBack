using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Funcionario : Netcore.ActivoFijo.Persistent.Funcionario
    {
        public static async Task<List<Funcionario>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Funcionario> query = (from q in Query.GetFuncionarios(context) select q);

            List<Funcionario> list = await query.ToList<Funcionario>();

            return list;
        }
    }
}