using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class PostTitulo : Netcore.ActivoFijo.Model.PostTitulo, IEquatable<object>
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

			Netcore.ActivoFijo.Model.PostTitulo primaryObject = other.Adapt<Netcore.ActivoFijo.Model.PostTitulo>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
