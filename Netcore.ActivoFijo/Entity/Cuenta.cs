using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Cuenta : Netcore.ActivoFijo.Model.Cuentum, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Cuentum primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Cuentum>();

			return primaryObject.Id.Equals(this.Id) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.EmpresaId.Equals(this.EmpresaId);
		}
	}
}
