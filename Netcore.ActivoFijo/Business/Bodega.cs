using Microsoft.EntityFrameworkCore;
using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Bodega : Netcore.ActivoFijo.Persistent.Bodega
    {
        public static async Task<List<Bodega>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Bodega> query = (from q in Query.GetBodegas(context) select q);

            List<Bodega> list = await query.ToList<Bodega>();

            return list;
        }
        public static async Task<List<Bodega>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context, Guid cc)
        {
            var data =  (from q in Query.GetBodegasPaginated(context, cc) select q);

            IQueryable<Netcore.ActivoFijo.Model.Bodega> query = data;
            List<Bodega> list = await query.ToList<Bodega>();

            return list;
        }

        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.Bodegas.Count();
        }
        public static async Task<Bodega> Insert(
           Netcore.ActivoFijo.Model.Context context,
           Guid empresaId,
           Guid centroCostoId,
           string nombre,
           string? sigla,
           string? descripcion,
           string? Id
           )
        {
            try
            {
                Bodega newElement = new Bodega();
                newElement.EmpresaId = empresaId;
                newElement.CentroCostoId = centroCostoId;
                newElement.Nombre = nombre;
                newElement.Sigla = sigla;
                newElement.Descripcion = descripcion;
                
                if (!string.IsNullOrEmpty(Id)) {
                    newElement.Id = Guid.Parse(Id);
                    } else {
                        newElement.Id = Guid.NewGuid();
                    } 
                await newElement.Save(context);
                await context.SaveChangesAsync();
                return newElement;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}