using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class SucursalBancaria : Netcore.ActivoFijo.Model.SucursalBancarium, IEquatable<object>
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

			Netcore.ActivoFijo.Model.SucursalBancarium primaryObject = other.Adapt<Netcore.ActivoFijo.Model.SucursalBancarium>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
