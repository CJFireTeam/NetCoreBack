using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Unidad
{
    public Guid EmpresaId { get; set; }

    public Guid Id { get; set; }

    public Guid? AdministradorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual Persona? Administrador { get; set; }

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();

    public virtual Empresa Empresa { get; set; } = null!;
}
