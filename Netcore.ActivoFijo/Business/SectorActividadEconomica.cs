using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class SectorActividadEconomica : Netcore.ActivoFijo.Entity.SectorActividadEconomica
    {
        public static async Task<List<SectorActividadEconomica>> GetAllAsync(Netcore.ActivoFijo.Model.Context context,int actividad)
        {
            IQueryable<Netcore.ActivoFijo.Model.SectorActividadEconomica> query = (from q in Query.GetSectorActividadEconomicas(context,actividad) select q);

            List<SectorActividadEconomica> list = await query.ToList<SectorActividadEconomica>();

            return list;
        }
    }
}