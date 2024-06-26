using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class AnoMes : Netcore.ActivoFijo.Model.AnoMe, IEquatable<object>
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

			Netcore.ActivoFijo.Model.AnoMe primaryObject = other.Adapt<Netcore.ActivoFijo.Model.AnoMe>();

			return primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.MesNumero.Equals(this.MesNumero);
		}
	}
}
