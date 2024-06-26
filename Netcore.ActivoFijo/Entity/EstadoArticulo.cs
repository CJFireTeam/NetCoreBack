using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class EstadoArticulo : Netcore.ActivoFijo.Model.EstadoArticulo, IEquatable<object>
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

			Netcore.ActivoFijo.Model.EstadoArticulo primaryObject = other.Adapt<Netcore.ActivoFijo.Model.EstadoArticulo>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
