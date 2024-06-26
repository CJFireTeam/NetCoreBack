using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class InstitucionValorSeguro : Netcore.ActivoFijo.Model.InstitucionValorSeguro, IEquatable<object>
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

			Netcore.ActivoFijo.Model.InstitucionValorSeguro primaryObject = other.Adapt<Netcore.ActivoFijo.Model.InstitucionValorSeguro>();

			return primaryObject.TipoInstitucionValorSeguroCodigo.Equals(this.TipoInstitucionValorSeguroCodigo) ^ primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
