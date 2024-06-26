using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class ArticuloValor : Netcore.ActivoFijo.Model.ArticuloValor, IEquatable<object>
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

			Netcore.ActivoFijo.Model.ArticuloValor primaryObject = other.Adapt<Netcore.ActivoFijo.Model.ArticuloValor>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.SubFamiliaId.Equals(this.SubFamiliaId) ^ primaryObject.ArticuloId.Equals(this.ArticuloId) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
