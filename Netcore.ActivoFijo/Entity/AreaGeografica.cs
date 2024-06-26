using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class AreaGeografica : Netcore.ActivoFijo.Model.AreaGeografica, IEquatable<object>
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

			Netcore.ActivoFijo.Model.AreaGeografica primaryObject = other.Adapt<Netcore.ActivoFijo.Model.AreaGeografica>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
