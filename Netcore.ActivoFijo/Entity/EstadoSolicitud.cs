using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class EstadoSolicitud : Netcore.ActivoFijo.Model.EstadoSolicitud, IEquatable<object>
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

			Netcore.ActivoFijo.Model.EstadoSolicitud primaryObject = other.Adapt<Netcore.ActivoFijo.Model.EstadoSolicitud>();

			return primaryObject.Codigo.Equals(this.Codigo);
		}
	}
}
