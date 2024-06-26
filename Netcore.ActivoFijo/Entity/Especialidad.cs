using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Especialidad : Netcore.ActivoFijo.Model.Especialidad, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Especialidad primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Especialidad>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
