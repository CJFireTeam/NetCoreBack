using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Contacto : Netcore.ActivoFijo.Model.Contacto, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Contacto primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Contacto>();

			return primaryObject.Id.Equals(this.Id);
		}
	}
}
