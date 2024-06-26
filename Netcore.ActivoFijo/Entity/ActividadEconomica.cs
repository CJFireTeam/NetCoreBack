using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class ActividadEconomica : Netcore.ActivoFijo.Model.ActividadEconomica, IEquatable<object>
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

			Netcore.ActivoFijo.Model.ActividadEconomica primaryObject = other.Adapt<Netcore.ActivoFijo.Model.ActividadEconomica>();

			return primaryObject.ActividadEconomicaPrincipalCodigo.Equals(this.ActividadEconomicaPrincipalCodigo) ^ primaryObject.SectorActividadEconomicaCodigo.Equals(this.SectorActividadEconomicaCodigo) ^ primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
