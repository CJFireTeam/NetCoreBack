using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Programa : Netcore.ActivoFijo.Model.Programa, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Programa primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Programa>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
