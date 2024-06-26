using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class ComprobanteTipo : Netcore.ActivoFijo.Model.ComprobanteTipo, IEquatable<object>
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

			Netcore.ActivoFijo.Model.ComprobanteTipo primaryObject = other.Adapt<Netcore.ActivoFijo.Model.ComprobanteTipo>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
