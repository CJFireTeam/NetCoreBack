using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class SucursalBancarium
{
    public Guid EmpresaId { get; set; }

    public Guid Id { get; set; }

    public int TipoInstitucionValorSeguroCodigo { get; set; }

    public int InstitucionValorSeguroCodigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public short? RegionCodigo { get; set; }

    public short? CiudadCodigo { get; set; }

    public short? ComunaCodigo { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono1 { get; set; }

    public int? Telefono2 { get; set; }

    public int? Fax { get; set; }

    public int? Celular { get; set; }

    public bool Eliminado { get; set; }

    public virtual Comuna? Comuna { get; set; }

    public virtual ICollection<CuentaCorriente> CuentaCorrientes { get; set; } = new List<CuentaCorriente>();

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual InstitucionValorSeguro InstitucionValorSeguro { get; set; } = null!;
}
