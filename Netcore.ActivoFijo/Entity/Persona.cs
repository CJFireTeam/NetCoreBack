using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Persona : Netcore.ActivoFijo.Model.Persona, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Persona primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Persona>();

			return primaryObject.Id.Equals(this.Id);
		}
	}
}
