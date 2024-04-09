using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoDocumentoRecepcion : Netcore.ActivoFijo.Model.TipoDocumentoRecepcion, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoDocumentoRecepcion primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoDocumentoRecepcion>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
