using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class CotizacionDetalle : Netcore.ActivoFijo.Model.CotizacionDetalle, IEquatable<object>
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

			Netcore.ActivoFijo.Model.CotizacionDetalle primaryObject = other.Adapt<Netcore.ActivoFijo.Model.CotizacionDetalle>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.CotizacionId.Equals(this.CotizacionId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
