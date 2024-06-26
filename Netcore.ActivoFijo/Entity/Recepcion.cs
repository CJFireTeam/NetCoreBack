using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Recepcion : Netcore.ActivoFijo.Model.Recepcion, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Recepcion primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Recepcion>();

			return primaryObject.CotizacionId.Equals(this.CotizacionId) ^ primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
