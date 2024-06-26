using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Cotizacion : Netcore.ActivoFijo.Model.Cotizacion, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Cotizacion primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Cotizacion>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
