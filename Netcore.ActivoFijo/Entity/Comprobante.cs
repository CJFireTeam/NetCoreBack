using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Comprobante : Netcore.ActivoFijo.Model.Comprobante, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Comprobante primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Comprobante>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
