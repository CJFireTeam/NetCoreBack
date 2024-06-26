using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Departamento : Netcore.ActivoFijo.Model.Departamento, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Departamento primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Departamento>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.UnidadId.Equals(this.UnidadId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
