using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Unidad : Netcore.ActivoFijo.Model.Unidad, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Unidad primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Unidad>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}