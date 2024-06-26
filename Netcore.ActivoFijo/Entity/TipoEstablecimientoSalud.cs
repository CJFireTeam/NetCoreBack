using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoEstablecimientoSalud : Netcore.ActivoFijo.Model.TipoEstablecimientoSalud, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoEstablecimientoSalud primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoEstablecimientoSalud>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
