using Netcore.Abstraction.PartialOverload;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Netcore.ActivoFijo.Business
{
    public class Sexo : Netcore.ActivoFijo.Entity.Sexo
    {
        public static async Task<Sexo> GetAsync(Netcore.ActivoFijo.Model.Context context, int sexo)
        {
            Netcore.ActivoFijo.Model.Sexo? query = await Query.GetSexos(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Sexo>(x => x.Codigo == sexo);
            Sexo dato = query.SingleOrDefault<Sexo>();
            return dato;
        }
        public static async Task<List<Sexo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Sexo> query = (from q in Query.GetSexos(context) select q);

            List<Sexo> list = await query.ToList<Sexo>();

            return list;
        }
        

    }
}