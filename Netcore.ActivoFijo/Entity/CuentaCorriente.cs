using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class CuentaCorriente : Netcore.ActivoFijo.Model.CuentaCorriente, IEquatable<object>
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

			Netcore.ActivoFijo.Model.CuentaCorriente primaryObject = other.Adapt<Netcore.ActivoFijo.Model.CuentaCorriente>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.SucursalBancariaId.Equals(this.SucursalBancariaId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
