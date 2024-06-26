using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class PuebloIndigena : Netcore.ActivoFijo.Model.PuebloIndigena, IEquatable<object>
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

			Netcore.ActivoFijo.Model.PuebloIndigena primaryObject = other.Adapt<Netcore.ActivoFijo.Model.PuebloIndigena>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
