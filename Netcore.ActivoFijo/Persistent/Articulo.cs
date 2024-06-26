using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Articulo : Netcore.ActivoFijo.Entity.Articulo, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Articulo? articulo = await context.Articulos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Articulo>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.Id == this.Id);

            if (articulo == null)
            {
                articulo = new Articulo
                {
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    SubFamiliaId = this.SubFamiliaId,
                    Id = this.Id
                };

                await context.Articulos.AddAsync(articulo);
            }

            articulo.TipoUnidadCodigo = this.TipoUnidadCodigo;
            articulo.Codigo = this.Codigo;
            articulo.Nombre = this.Nombre;
            articulo.Descripcion = this.Descripcion;
            articulo.Eliminado = this.Eliminado;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Articulo? articulo = await context.Articulos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Articulo>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.Id == this.Id);

            if (articulo != null)
            {
                context.Articulos.Remove(articulo);
            }
        }
    }
}