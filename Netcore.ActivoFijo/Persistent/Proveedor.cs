using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Proveedor : Netcore.ActivoFijo.Entity.Proveedor, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Proveedor? proveedor = await context.Proveedors.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Proveedor>(x => x.Id == this.Id);

            if (proveedor == null)
            {
                proveedor = new Proveedor
                {
                    Id = this.Id
                };

                await context.Proveedors.AddAsync(proveedor);
            }

            proveedor.RutCuerpo = this.RutCuerpo;
            proveedor.RutDigito = this.RutDigito;
            proveedor.RazonSocial = this.RazonSocial;
            proveedor.NombreComercial = this.NombreComercial;
            proveedor.TipoCuentaCodigo = this.TipoCuentaCodigo == default(Int32) ? null : this.TipoCuentaCodigo;
            proveedor.NumeroCuenta = this.NumeroCuenta;
            proveedor.RegionCodigo = this.RegionCodigo == default(Int16) ? null : this.RegionCodigo;
            proveedor.CiudadCodigo = this.CiudadCodigo == default(Int16) ? null : this.CiudadCodigo;
            proveedor.ComunaCodigo = this.ComunaCodigo == default(Int16) ? null : this.ComunaCodigo;
            proveedor.Direccion = this.Direccion;
            proveedor.Email = this.Email;
            proveedor.PaginaWeb = this.PaginaWeb;
            proveedor.Telefono1 = this.Telefono1 == default(Int64) ? null : this.Telefono1;
            proveedor.Telefono2 = this.Telefono2 == default(Int64) ? null : this.Telefono2;
            proveedor.Fax = this.Fax == default(Int32) ? null : this.Fax;
            proveedor.Celular = this.Celular == default(Int32) ? null : this.Celular;
            proveedor.Eliminado = this.Eliminado;
            proveedor.InstitucionValorSeguroCodigo = this.InstitucionValorSeguroCodigo == default(Int32) ? null : this.InstitucionValorSeguroCodigo;
            proveedor.TipoInstitucionValorSeguroCodigo = this.TipoInstitucionValorSeguroCodigo == default(Int32) ? null : this.TipoInstitucionValorSeguroCodigo;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Proveedor? proveedor = await context.Proveedors.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Proveedor>(x => x.Id == this.Id);

            if (proveedor != null)
            {
                context.Proveedors.Remove(proveedor);
            }
        }
    }
}