using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoCuentaContable : Netcore.ActivoFijo.Model.TipoCuentum, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoCuentum primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoCuentum>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
