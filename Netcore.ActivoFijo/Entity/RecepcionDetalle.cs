using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class RecepcionDetalle : Netcore.ActivoFijo.Model.RecepcionDetalle, IEquatable<object>
	{
		public new bool Equals(object? other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			Netcore.ActivoFijo.Model.RecepcionDetalle primaryObject = other.Adapt<Netcore.ActivoFijo.Model.RecepcionDetalle>();

			return primaryObject.RecepcionId.Equals(this.RecepcionId) ^ primaryObject.CotizacionId.Equals(this.CotizacionId) ^ primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.CotizacionDetalleId.Equals(this.CotizacionDetalleId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero);
		}
	}
}
