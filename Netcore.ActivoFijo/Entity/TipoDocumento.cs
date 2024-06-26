using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoDocumento : Netcore.ActivoFijo.Model.TipoDocumento, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoDocumento primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoDocumento>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
