using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Empresa : Netcore.ActivoFijo.Entity.Empresa, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Empresa? empresa = await context.Empresas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Empresa>(x => x.Id == this.Id);

            if (empresa == null)
            {
                empresa = new Empresa
                {
                    Id = this.Id
                };

                await context.Empresas.AddAsync(empresa);
            }

            empresa.RutCuerpo = this.RutCuerpo;
            empresa.RutDigito = this.RutDigito;
            empresa.RazonSocial = this.RazonSocial;
            empresa.RegionCodigo = this.RegionCodigo == default(Int16) ? null : this.RegionCodigo;
            empresa.CiudadCodigo = this.CiudadCodigo == default(Int16) ? null : this.CiudadCodigo;
            empresa.ComunaCodigo = this.ComunaCodigo == default(Int16) ? null : this.ComunaCodigo;
            empresa.TipoAdministracionCodigo = this.TipoAdministracionCodigo;
            empresa.ActividadEconomicaPrincipalCodigo = this.ActividadEconomicaPrincipalCodigo == default(Int32) ? null : this.ActividadEconomicaPrincipalCodigo;
            empresa.SectorActividadEconomicaCodigo = this.SectorActividadEconomicaCodigo == default(Int32) ? null : this.SectorActividadEconomicaCodigo;
            empresa.ActividadEconomicaCodigo = this.ActividadEconomicaCodigo == default(Int32) ? null : this.ActividadEconomicaCodigo;
            empresa.Giro = this.Giro;
            empresa.Direccion = this.Direccion;
            empresa.Email = this.Email;
            empresa.PaginaWeb = this.PaginaWeb;
            empresa.Telefono1 = this.Telefono1 == default(Int32) ? null : this.Telefono1;
            empresa.Telefono2 = this.Telefono2 == default(Int32) ? null : this.Telefono2;
            empresa.Fax = this.Fax == default(Int32) ? null : this.Fax;
            empresa.Celular = this.Celular == default(Int32) ? null : this.Celular;
            empresa.AdministradorId = this.AdministradorId == default(Guid) ? null : this.AdministradorId;
            empresa.GerenteRrhhid = this.GerenteRrhhid == default(Guid) ? null : this.GerenteRrhhid;
            empresa.Bloqueada = this.Bloqueada;
            empresa.RutaReporte = this.RutaReporte;
            empresa.PieFirmaLiquidacion = this.PieFirmaLiquidacion;
            empresa.Url = this.Url;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Empresa? empresa = await context.Empresas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Empresa>(x => x.Id == this.Id);

            if (empresa != null)
            {
                context.Empresas.Remove(empresa);
            }
        }
    }
}