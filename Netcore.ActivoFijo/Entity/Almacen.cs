using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Almacen : Netcore.ActivoFijo.Model.Almacen, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Almacen primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Almacen>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.CentroCostoId.Equals(this.CentroCostoId) ^ primaryObject.BodegaId.Equals(this.BodegaId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
