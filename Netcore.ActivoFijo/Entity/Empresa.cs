using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Empresa : Netcore.ActivoFijo.Model.Empresa, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Empresa primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Empresa>();

			return primaryObject.Id.Equals(this.Id);
		}
	}
}
