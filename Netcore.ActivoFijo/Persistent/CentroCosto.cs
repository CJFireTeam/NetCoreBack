using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class CentroCosto : Netcore.ActivoFijo.Entity.CentroCosto, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.CentroCosto? centroCosto = await context.CentroCostos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.CentroCosto>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (centroCosto == null)
            {
                centroCosto = new CentroCosto
                {
                    EmpresaId = this.EmpresaId,
                    Id = this.Id
                };

                await context.CentroCostos.AddAsync(centroCosto);
            }

            centroCosto.CentroCostoId = this.CentroCostoId == default(Guid) ? null : this.CentroCostoId;
            centroCosto.AdministradorId = this.AdministradorId == default(Guid) ? null : this.AdministradorId;
            centroCosto.Nombre = this.Nombre;
            centroCosto.Sigla = this.Sigla;
            centroCosto.AreaGeograficaCodigo = this.AreaGeograficaCodigo;
            centroCosto.TipoEstablecimientoSaludCodigo = this.TipoEstablecimientoSaludCodigo == default(Int32) ? null : this.TipoEstablecimientoSaludCodigo;
            centroCosto.RegionCodigo = this.RegionCodigo == default(Int16) ? null : this.RegionCodigo;
            centroCosto.CiudadCodigo = this.CiudadCodigo == default(Int16) ? null : this.CiudadCodigo;
            centroCosto.ComunaCodigo = this.ComunaCodigo == default(Int16) ? null : this.ComunaCodigo;
            centroCosto.Email = this.Email;
            centroCosto.Direccion = this.Direccion;
            centroCosto.Telefono1 = this.Telefono1 == default(Int32) ? null : this.Telefono1;
            centroCosto.Telefono2 = this.Telefono2 == default(Int32) ? null : this.Telefono2;
            centroCosto.Fax = this.Fax == default(Int32) ? null : this.Fax;
            centroCosto.Celular = this.Celular == default(Int32) ? null : this.Celular;
            centroCosto.CodigoContabilidad = this.CodigoContabilidad;
            centroCosto.LibroRemuneraciones = this.LibroRemuneraciones;
            centroCosto.RutaReporte = this.RutaReporte;
            centroCosto.DepartamentoId = this.DepartamentoId == default(Guid) ? null : this.DepartamentoId;
            centroCosto.UnidadId = this.UnidadId == default(Guid) ? null : this.UnidadId;
            centroCosto.CodigoPrevired = this.CodigoPrevired;
            centroCosto.CodigoGesparvu = this.CodigoGesparvu == default(Int32) ? null : this.CodigoGesparvu;
            centroCosto.AdministracionCentral = this.AdministracionCentral;
            centroCosto.CodigoDipres = this.CodigoDipres;
            centroCosto.Contabilizacion = this.Contabilizacion;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.CentroCosto? centroCosto = await context.CentroCostos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.CentroCosto>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (centroCosto != null)
            {
                context.CentroCostos.Remove(centroCosto);
            }
        }
    }
}