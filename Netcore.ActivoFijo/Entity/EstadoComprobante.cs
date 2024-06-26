using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class EstadoComprobante : Netcore.ActivoFijo.Model.EstadoComprobante, IEquatable<object>
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

			Netcore.ActivoFijo.Model.EstadoComprobante primaryObject = other.Adapt<Netcore.ActivoFijo.Model.EstadoComprobante>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
