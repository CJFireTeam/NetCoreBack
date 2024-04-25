using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Locacion : Netcore.ActivoFijo.Persistent.Locacion
    {
        public static async Task<List<Locacion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Locacion> query = (from q in Query.GetLocaciones(context) select q);

            List<Locacion> list = await query.ToList<Locacion>();

            return list;
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