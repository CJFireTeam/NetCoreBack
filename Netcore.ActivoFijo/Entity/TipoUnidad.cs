using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoUnidad : Netcore.ActivoFijo.Model.TipoUnidad, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoUnidad primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoUnidad>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
