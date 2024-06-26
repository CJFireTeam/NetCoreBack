using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Locacion : Netcore.ActivoFijo.Persistent.Locacion
    {
        public static async Task<List<Locacion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context, string id)
        {
            IQueryable<Netcore.ActivoFijo.Model.Locacion> query = (from q in Query.GetLocaciones(context, id) select q);

            List<Locacion> list = await query.ToList<Locacion>();

            return list;
        }
        public static async Task<List<Locacion>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context, int page, int perPage)
        {
            IQueryable<Netcore.ActivoFijo.Model.Locacion> query = (from q in Query.GetLocacionsPaginated(context, page, perPage) select q);

            List<Locacion> list = await query.ToList<Locacion>();

            return list;
        }

        public static async Task<List<Locacion>> GetOne(Netcore.ActivoFijo.Model.Context context, Guid id)
        {
            IQueryable<Netcore.ActivoFijo.Model.Locacion> query = (from q in Query.GetLocacionesOne(context, id) select q);
            List<Locacion> list = await query.ToList<Locacion>();
            return list;
        }

        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.Locacions.Count();
        }
        public static async Task<Locacion> Insert(
            Netcore.ActivoFijo.Model.Context context,
            Guid empresaId,
            Guid id,
            Guid? centroCostoId,
            Guid? bodegaId,
            Guid? almacenId,
            Guid tipoLocacionId,
            string direccion,
            string? descripcion

            )
        {
            try
            {
                Locacion newElement = new Locacion();
                newElement.EmpresaId = empresaId;
                newElement.Id = id;
                newElement.CentroCostoId = centroCostoId;
                newElement.BodegaId = bodegaId;
                newElement.AlmacenId = almacenId;
                newElement.TipoLocacionId = tipoLocacionId;
                newElement.Direccion = direccion;
                newElement.Descripcion = descripcion;



                await newElement.Save(context);
                await context.SaveChangesAsync();
                return newElement;
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}