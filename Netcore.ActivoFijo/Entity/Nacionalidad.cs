using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Nacionalidad : Netcore.ActivoFijo.Model.Nacionalidad, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Nacionalidad primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Nacionalidad>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
