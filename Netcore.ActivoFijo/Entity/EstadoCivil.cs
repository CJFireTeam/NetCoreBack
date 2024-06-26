using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class EstadoCivil : Netcore.ActivoFijo.Model.EstadoCivil, IEquatable<object>
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

			Netcore.ActivoFijo.Model.EstadoCivil primaryObject = other.Adapt<Netcore.ActivoFijo.Model.EstadoCivil>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
