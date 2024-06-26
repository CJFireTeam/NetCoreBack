using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class SolicitudDetalle : Netcore.ActivoFijo.Model.SolicitudDetalle, IEquatable<object>
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

			Netcore.ActivoFijo.Model.SolicitudDetalle primaryObject = other.Adapt<Netcore.ActivoFijo.Model.SolicitudDetalle>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.SolicitudId.Equals(this.SolicitudId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
