using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Cliente : Netcore.ActivoFijo.Model.Cliente, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Cliente primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Cliente>();

			return primaryObject.Id.Equals(this.Id) ^ primaryObject.EmpresaId.Equals(this.EmpresaId);
		}
	}
}
