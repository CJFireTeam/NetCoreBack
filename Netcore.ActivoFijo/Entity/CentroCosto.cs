using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class CentroCosto : Netcore.ActivoFijo.Model.CentroCosto, IEquatable<object>
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

			Netcore.ActivoFijo.Model.CentroCosto primaryObject = other.Adapt<Netcore.ActivoFijo.Model.CentroCosto>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
