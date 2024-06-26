using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoGastoOperacional : Netcore.ActivoFijo.Model.TipoGastoOperacional, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoGastoOperacional primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoGastoOperacional>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
