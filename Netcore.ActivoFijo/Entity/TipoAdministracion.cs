using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoAdministracion : Netcore.ActivoFijo.Model.TipoAdministracion, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoAdministracion primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoAdministracion>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
