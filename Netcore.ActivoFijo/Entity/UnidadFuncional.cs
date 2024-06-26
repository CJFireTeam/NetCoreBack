using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class UnidadFuncional : Netcore.ActivoFijo.Model.UnidadFuncional, IEquatable<object>
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

			Netcore.ActivoFijo.Model.UnidadFuncional primaryObject = other.Adapt<Netcore.ActivoFijo.Model.UnidadFuncional>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
