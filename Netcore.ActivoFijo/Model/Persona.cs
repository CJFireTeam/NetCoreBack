using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Persona
{
    public Guid Id { get; set; }

    public string? Run { get; set; }

    public int RunCuerpo { get; set; }

    public string RunDigito { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Nombres { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public string? Email { get; set; }

    public short SexoCodigo { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public short? NacionalidadCodigo { get; set; }

    public short? EstadoCivilCodigo { get; set; }

    public int? NivelEducacionalCodigo { get; set; }

    public short? RegionCodigo { get; set; }

    public short? CiudadCodigo { get; set; }

    public short? ComunaCodigo { get; set; }

    public short? RegionNacimientoCodigo { get; set; }

    public short? CiudadNacimientoCodigo { get; set; }

    public short? ComunaNacimientoCodigo { get; set; }

    public string? VillaPoblacion { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono { get; set; }

    public int? Celular { get; set; }

    public string? Observaciones { get; set; }

    public string? Ocupacion { get; set; }

    public int? TelefonoLaboral { get; set; }

    public string? DireccionLaboral { get; set; }

    public byte[]? Huella { get; set; }

    public byte[]? ImagenHuella { get; set; }

    public int? AreaGeograficaCodigo { get; set; }

    public string? NroDepartamento { get; set; }

    public virtual AreaGeografica? AreaGeograficaCodigoNavigation { get; set; }

    public virtual ICollection<CentroCosto> CentroCostos { get; set; } = new List<CentroCosto>();

    public virtual Comuna? Comuna { get; set; }

    public virtual Comuna? ComunaNavigation { get; set; }

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();

    public virtual ICollection<Empresa> EmpresaAdministradors { get; set; } = new List<Empresa>();

    public virtual ICollection<Empresa> EmpresaGerenteRrhhs { get; set; } = new List<Empresa>();

    public virtual EstadoCivil? EstadoCivilCodigoNavigation { get; set; }

    public virtual Funcionario? Funcionario { get; set; }

    public virtual ICollection<FuncionarioEmpresa> FuncionarioEmpresas { get; set; } = new List<FuncionarioEmpresa>();

    public virtual Nacionalidad? NacionalidadCodigoNavigation { get; set; }

    public virtual NivelEducacional? NivelEducacionalCodigoNavigation { get; set; }

    public virtual Sexo SexoCodigoNavigation { get; set; } = null!;

    public virtual ICollection<Unidad> Unidads { get; set; } = new List<Unidad>();
}
