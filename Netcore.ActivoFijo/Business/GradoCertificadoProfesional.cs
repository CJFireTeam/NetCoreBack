using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class GradoCertificadoProfesional : Netcore.ActivoFijo.Entity.GradoCertificadoProfesional
    {
        public static async Task<List<GradoCertificadoProfesional>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.GradoCertificadoProfesional> query = (from q in Query.GetGradoCertificadoProfesionales(context) select q);

            List<GradoCertificadoProfesional> list = await query.ToList<GradoCertificadoProfesional>();

            return list;
        }
    }
}