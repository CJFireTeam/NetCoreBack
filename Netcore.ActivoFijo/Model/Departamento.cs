using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Departamento
{
    public Guid EmpresaId { get; set; }

    public Guid UnidadId { get; set; }

    public Guid Id { get; set; }

    public Guid? AdministradorId { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Codigo { get; set; }

    public string? Clave { get; set; }

    public bool CerrarPorArea { get; set; }

    public virtual Persona? Administrador { get; set; }

    public virtual ICollection<CentroCosto> CentroCostos { get; set; } = new List<CentroCosto>();

    public virtual ICollection<Comprobante> Comprobantes { get; set; } = new List<Comprobante>();

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();

    public virtual Unidad Unidad { get; set; } = null!;
}
