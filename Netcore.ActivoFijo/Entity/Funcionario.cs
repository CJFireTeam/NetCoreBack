using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class Funcionario : Netcore.ActivoFijo.Model.Funcionario, IEquatable<object>
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

			Netcore.ActivoFijo.Model.Funcionario primaryObject = other.Adapt<Netcore.ActivoFijo.Model.Funcionario>();

			return primaryObject.Id.Equals(this.Id);
		}
	}
}
