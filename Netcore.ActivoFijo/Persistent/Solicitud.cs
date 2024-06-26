using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Solicitud : Netcore.ActivoFijo.Entity.Solicitud, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Solicitud? solicitud = await context.Solicituds.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Solicitud>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (solicitud == null)
            {
                solicitud = new Solicitud
                {
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    Id = this.Id
                };

                await context.Solicituds.AddAsync(solicitud);
            }

            solicitud.CentroCostoId = this.CentroCostoId;
            solicitud.SolicitanteId = this.SolicitanteId;
            solicitud.ProgramaId = this.ProgramaId;
            solicitud.EstadoSolicitudCodigo = this.EstadoSolicitudCodigo;
            solicitud.Numero = this.Numero;
            solicitud.Nombre = this.Nombre;
            solicitud.FechaIngreso = this.FechaIngreso;
            solicitud.Observaciones = this.Observaciones;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Solicitud? solicitud = await context.Solicituds.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Solicitud>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (solicitud != null)
            {
                context.Solicituds.Remove(solicitud);
            }
        }
    }
}