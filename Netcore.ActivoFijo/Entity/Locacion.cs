using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Locacion : Netcore.ActivoFijo.Model.Locacion, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Locacion primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Locacion>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
