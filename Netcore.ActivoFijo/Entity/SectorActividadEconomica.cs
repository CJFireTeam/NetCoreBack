using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class SectorActividadEconomica : Netcore.ActivoFijo.Model.SectorActividadEconomica, IEquatable<object>
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

			Netcore.ActivoFijo.Model.SectorActividadEconomica primaryObject = other.Adapt<Netcore.ActivoFijo.Model.SectorActividadEconomica>();

			return primaryObject.ActividadEconomicaPrincipalCodigo.Equals(this.ActividadEconomicaPrincipalCodigo) ^ primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
