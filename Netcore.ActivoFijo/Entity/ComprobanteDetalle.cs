using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class ComprobanteDetalle : Netcore.ActivoFijo.Model.ComprobanteDetalle, IEquatable<object>
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

			Netcore.ActivoFijo.Model.ComprobanteDetalle primaryObject = other.Adapt<Netcore.ActivoFijo.Model.ComprobanteDetalle>();

			return primaryObject.ComprobanteId.Equals(this.ComprobanteId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
