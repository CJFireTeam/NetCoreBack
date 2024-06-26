using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Proveedor : Netcore.ActivoFijo.Model.Proveedor, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Proveedor primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Proveedor>();

			return primaryObject.Id.Equals(this.Id);
		}
	}
}
