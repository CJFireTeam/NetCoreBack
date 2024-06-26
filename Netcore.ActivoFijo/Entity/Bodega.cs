using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Bodega : Netcore.ActivoFijo.Model.Bodega, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Bodega primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Bodega>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.CentroCostoId.Equals(this.CentroCostoId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
