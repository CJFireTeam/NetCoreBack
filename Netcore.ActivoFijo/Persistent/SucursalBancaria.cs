using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class SucursalBancaria : Netcore.ActivoFijo.Entity.SucursalBancaria, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.SucursalBancarium? sucursalBancaria = await context.SucursalBancaria.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.SucursalBancarium>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (sucursalBancaria == null)
            {
                sucursalBancaria = new SucursalBancaria
                {
                    EmpresaId = this.EmpresaId,
                    Id = this.Id
                };

                await context.SucursalBancaria.AddAsync(sucursalBancaria);
            }

            sucursalBancaria.TipoInstitucionValorSeguroCodigo = this.TipoInstitucionValorSeguroCodigo;
            sucursalBancaria.InstitucionValorSeguroCodigo = this.InstitucionValorSeguroCodigo;
            sucursalBancaria.Nombre = this.Nombre;
            sucursalBancaria.Descripcion = this.Descripcion;
            sucursalBancaria.RegionCodigo = this.RegionCodigo == default(Int16) ? null : this.RegionCodigo;
            sucursalBancaria.CiudadCodigo = this.CiudadCodigo == default(Int16) ? null : this.CiudadCodigo;
            sucursalBancaria.ComunaCodigo = this.ComunaCodigo == default(Int16) ? null : this.ComunaCodigo;
            sucursalBancaria.Email = this.Email;
            sucursalBancaria.Direccion = this.Direccion;
            sucursalBancaria.Telefono1 = this.Telefono1 == default(Int32) ? null : this.Telefono1;
            sucursalBancaria.Telefono2 = this.Telefono2 == default(Int32) ? null : this.Telefono2;
            sucursalBancaria.Fax = this.Fax == default(Int32) ? null : this.Fax;
            sucursalBancaria.Celular = this.Celular == default(Int32) ? null : this.Celular;
            sucursalBancaria.Eliminado = this.Eliminado;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.SucursalBancarium? sucursalBancaria = await context.SucursalBancaria.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.SucursalBancarium>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (sucursalBancaria != null)
            {
                context.SucursalBancaria.Remove(sucursalBancaria);
            }
        }
    }
}