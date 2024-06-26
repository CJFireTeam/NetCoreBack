using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
	public class Comprobante: Netcore.ActivoFijo.Entity.Comprobante, Netcore.ActivoFijo.Interface.IRecordable
	{
		public async Task Save(Netcore.ActivoFijo.Model.Context context)
		{
			Netcore.ActivoFijo.Model.Comprobante? comprobante = await context.Comprobantes.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Comprobante>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

			if (comprobante == null)
			{
				comprobante = new Comprobante
				{
					EmpresaId = this.EmpresaId,
					AnoNumero = this.AnoNumero,
					Id = this.Id
				};

				await context.Comprobantes.AddAsync(comprobante);
			}

			comprobante.UnidadId = this.UnidadId == default(Guid) ? null : this.UnidadId;
			comprobante.DepartamentoId = this.DepartamentoId == default(Guid) ? null : this.DepartamentoId;
			comprobante.FuncionarioId = this.FuncionarioId;
			comprobante.ComprobanteTipoCodigo = this.ComprobanteTipoCodigo;
			comprobante.EstadoComprobanteCodigo = this.EstadoComprobanteCodigo;
			comprobante.Fecha = this.Fecha;
			comprobante.Numero = this.Numero;
			comprobante.TotalDebe = this.TotalDebe;
			comprobante.TotalHaber = this.TotalHaber;
			comprobante.GlosaGlobal = this.GlosaGlobal;
			comprobante.MesNumero = this.MesNumero == default(Int32) ? null : this.MesNumero;
			comprobante.Remuneracion = this.Remuneracion;
			comprobante.Honorario = this.Honorario;
			comprobante.Apertura = this.Apertura;
		}

		public async Task Delete(Netcore.ActivoFijo.Model.Context context)
		{
			Netcore.ActivoFijo.Model.Comprobante? comprobante = await context.Comprobantes.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Comprobante>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

			if (comprobante != null)
			{
				context.Comprobantes.Remove(comprobante);
			}
		}
	}
}
