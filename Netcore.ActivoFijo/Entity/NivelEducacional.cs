using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class NivelEducacional : Netcore.ActivoFijo.Model.NivelEducacional, IEquatable<object>
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

			Netcore.ActivoFijo.Model.NivelEducacional primaryObject = other.Adapt<Netcore.ActivoFijo.Model.NivelEducacional>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
