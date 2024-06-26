using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoCuentaEstadoResultado : Netcore.ActivoFijo.Model.TipoCuentaEstadoResultado, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoCuentaEstadoResultado primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoCuentaEstadoResultado>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
