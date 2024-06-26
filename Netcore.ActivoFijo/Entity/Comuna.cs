using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Comuna : Netcore.ActivoFijo.Model.Comuna, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Comuna primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Comuna>();

			return primaryObject.RegionCodigo.Equals(this.RegionCodigo) ^ primaryObject.CiudadCodigo.Equals(this.CiudadCodigo) ^ primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
