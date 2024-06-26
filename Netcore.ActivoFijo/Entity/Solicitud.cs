using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Solicitud : Netcore.ActivoFijo.Model.Solicitud, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Solicitud primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Solicitud>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
