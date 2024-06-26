using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class ActividadEconomicaPrincipal : Netcore.ActivoFijo.Model.ActividadEconomicaPrincipal, IEquatable<object>
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

			Netcore.ActivoFijo.Model.ActividadEconomicaPrincipal primaryObject = other.Adapt<Netcore.ActivoFijo.Model.ActividadEconomicaPrincipal>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
