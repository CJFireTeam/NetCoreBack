using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class FuncionarioEmpresa : Netcore.ActivoFijo.Persistent.FuncionarioEmpresa
    {
        public static async Task<List<FuncionarioEmpresa>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.FuncionarioEmpresa> query = (from q in Query.GetFuncionarioEmpresas(context) select q);

            List<FuncionarioEmpresa> list = await query.ToList<FuncionarioEmpresa>();

            return list;
        }
    }
}