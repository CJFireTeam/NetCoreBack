using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class OrdenCompra : Netcore.ActivoFijo.Model.OrdenCompra, IEquatable<object>
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

			Netcore.ActivoFijo.Model.OrdenCompra primaryObject = other.Adapt<Netcore.ActivoFijo.Model.OrdenCompra>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.CotizacionId.Equals(this.CotizacionId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero);
		}
	}
}
