using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class GradoCertificadoProfesional : Netcore.ActivoFijo.Model.GradoCertificadoProfesional, IEquatable<object>
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

			Netcore.ActivoFijo.Model.GradoCertificadoProfesional primaryObject = other.Adapt<Netcore.ActivoFijo.Model.GradoCertificadoProfesional>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
