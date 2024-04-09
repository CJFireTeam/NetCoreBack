using Mapster;

namespace Netcore.ActivoFijo.Entity
{
    public class TipoCuenta : Netcore.ActivoFijo.Model.TipoCuentum1, IEquatable<object>
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

            Netcore.ActivoFijo.Model.TipoCuentum1 primaryObject = other.Adapt<Netcore.ActivoFijo.Model.TipoCuentum1>();

            return primaryObject.Codigo.Equals(this.Codigo) ^ primaryObject.Codigo.Equals(this.Codigo);
        }
    }
}