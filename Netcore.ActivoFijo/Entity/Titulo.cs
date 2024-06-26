using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Titulo : Netcore.ActivoFijo.Model.Titulo, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Titulo primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Titulo>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
