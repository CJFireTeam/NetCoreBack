using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class ActividadEconomicaPrincipal : Netcore.ActivoFijo.Entity.ActividadEconomicaPrincipal
    {
        public static async Task<List<ActividadEconomicaPrincipal>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.ActividadEconomicaPrincipal> query = (from q in Query.GetActividadEconomicaPrincipales(context) select q);

            List<ActividadEconomicaPrincipal> list = await query.ToList<ActividadEconomicaPrincipal>();

            return list;
        }
    }
}