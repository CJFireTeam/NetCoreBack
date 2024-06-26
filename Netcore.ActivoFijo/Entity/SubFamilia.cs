using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class SubFamilia : Netcore.ActivoFijo.Model.SubFamilium, IEquatable<object>
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

			Netcore.ActivoFijo.Model.SubFamilium primaryObject = other.Adapt<Netcore.ActivoFijo.Model.SubFamilium>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.AnoNumero.Equals(this.AnoNumero) ^ primaryObject.Id.Equals(this.Id);
		}
	}
}
