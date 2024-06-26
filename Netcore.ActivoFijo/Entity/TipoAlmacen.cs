using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoAlmacen : Netcore.ActivoFijo.Model.TipoAlmacen, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoAlmacen primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoAlmacen>();

			return primaryObject.Id.Equals(this.Id);
		}
	}
}
