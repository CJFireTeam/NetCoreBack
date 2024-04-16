using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Empresa : Netcore.ActivoFijo.Persistent.Empresa
    {
        public static async Task<List<Empresa>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Empresa> query = (from q in Query.GetEmpresas(context) select q);

            List<Empresa> list = await query.ToList<Empresa>();

            return list;
        }

        public static async Task<Empresa> Insert(
            Netcore.ActivoFijo.Model.Context context,
            int rutBody,
            string rutDigit,
            string RazonSocial,
            int  TipoAdministracionCodigo,
            bool  Bloqueada
            )
        {
            try
            {
                Empresa newElement = new Empresa();
                newElement.RutCuerpo = rutBody;
                newElement.RutDigito = rutDigit;
                newElement.RazonSocial = RazonSocial;
                newElement.TipoAdministracionCodigo = TipoAdministracionCodigo;
                newElement.Bloqueada = Bloqueada;
                
                await newElement.Save(context);
                await context.SaveChangesAsync();
                return newElement;
            }
            catch (System.Exception e)
            {

                throw;
            }

        }
    }
}