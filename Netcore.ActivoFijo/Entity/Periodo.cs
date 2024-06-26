using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Periodo : Netcore.ActivoFijo.Model.Periodo, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Periodo primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Periodo>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.MesNumero.Equals(this.MesNumero);
		}
	}
}
