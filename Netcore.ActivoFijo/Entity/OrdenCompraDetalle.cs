using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class OrdenCompraDetalle : Netcore.ActivoFijo.Model.OrdenCompraDetalle, IEquatable<object>
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

			Netcore.ActivoFijo.Model.OrdenCompraDetalle primaryObject = other.Adapt<Netcore.ActivoFijo.Model.OrdenCompraDetalle>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.CotizacionId.Equals(this.CotizacionId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.CotizacionDetalleId.Equals(this.CotizacionDetalleId);
		}
	}
}
