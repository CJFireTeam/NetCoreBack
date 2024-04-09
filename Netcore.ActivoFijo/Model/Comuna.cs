using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Comuna
{
    public short RegionCodigo { get; set; }

    public short CiudadCodigo { get; set; }

    public short Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? CodigoDipres { get; set; }

    public int CodigoPostal { get; set; }

    public int CodigoLibroClaseElectronico { get; set; }

    public int? CodigoLre { get; set; }

    public virtual ICollection<CentroCosto> CentroCostos { get; set; } = new List<CentroCosto>();

    public virtual Ciudad Ciudad { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual ICollection<Persona> PersonaComunaNavigations { get; set; } = new List<Persona>();

    public virtual ICollection<Persona> PersonaComunas { get; set; } = new List<Persona>();

    public virtual ICollection<SucursalBancarium> SucursalBancaria { get; set; } = new List<SucursalBancarium>();
}
