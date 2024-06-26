using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoIngresoOperacional : Netcore.ActivoFijo.Model.TipoIngresoOperacional, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoIngresoOperacional primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoIngresoOperacional>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
