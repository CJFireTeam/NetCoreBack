using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class ParteEntrada : Netcore.ActivoFijo.Model.ParteEntradum, IEquatable<object>
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

			Netcore.ActivoFijo.Model.ParteEntradum primaryObject = other.Adapt<Netcore.ActivoFijo.Model.ParteEntradum>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.CentroCostoId.Equals(this.CentroCostoId) ^ primaryObject.BodegaId.Equals(this.BodegaId) ^ primaryObject.AlmacenId.Equals(this.AlmacenId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.SubFamiliaId.Equals(this.SubFamiliaId) ^ primaryObject.ArticuloId.Equals(this.ArticuloId) ^ primaryObject.EstadoArticuloCodigo.Equals(this.EstadoArticuloCodigo) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
