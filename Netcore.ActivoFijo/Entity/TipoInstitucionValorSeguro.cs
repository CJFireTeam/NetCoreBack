using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class TipoInstitucionValorSeguro : Netcore.ActivoFijo.Model.TipoInstitucionValorSeguro, IEquatable<object>
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

			Netcore.ActivoFijo.Model.TipoInstitucionValorSeguro primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoInstitucionValorSeguro>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
