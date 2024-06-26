using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Ano : Netcore.ActivoFijo.Model.Ano, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Ano primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Ano>();

			return primaryObject.Numero.Equals(this.Numero);
		}
	}
}
