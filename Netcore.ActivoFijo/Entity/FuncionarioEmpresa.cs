using Mapster;

namespace Netcore.ActivoFijo.Entity
{
	public class FuncionarioEmpresa : Netcore.ActivoFijo.Model.FuncionarioEmpresa, IEquatable<object>
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

			Netcore.ActivoFijo.Model.FuncionarioEmpresa primaryObject = other.Adapt<Netcore.ActivoFijo.Model.FuncionarioEmpresa>();

			return primaryObject.EmpresaId.Equals(this.EmpresaId) ^ primaryObject.FuncionarioId.Equals(this.FuncionarioId);
		}
	}
}
