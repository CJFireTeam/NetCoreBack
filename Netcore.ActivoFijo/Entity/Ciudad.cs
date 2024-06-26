using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Ciudad : Netcore.ActivoFijo.Model.Ciudad, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Ciudad primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Ciudad>();

			return primaryObject.RegionCodigo.Equals(this.RegionCodigo) ^ primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
