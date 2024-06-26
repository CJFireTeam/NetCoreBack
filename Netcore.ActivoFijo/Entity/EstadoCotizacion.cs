using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class EstadoCotizacion : Netcore.ActivoFijo.Model.EstadoCotizacion, IEquatable<object>
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

			Netcore.ActivoFijo.Model.EstadoCotizacion primaryObject = other.Adapt<Netcore.ActivoFijo.Model.EstadoCotizacion>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
