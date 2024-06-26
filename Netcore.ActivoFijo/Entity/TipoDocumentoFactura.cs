using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoDocumentoFactura : Netcore.ActivoFijo.Model.TipoDocumentoFactura, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoDocumentoFactura primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoDocumentoFactura>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
