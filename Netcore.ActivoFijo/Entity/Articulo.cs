using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Articulo : Netcore.ActivoFijo.Model.Articulo, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Articulo primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Articulo>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.SubFamiliaId.Equals(this.SubFamiliaId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
