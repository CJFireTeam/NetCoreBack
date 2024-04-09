using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Cliente
{
    public Guid Id { get; set; }

    public Guid EmpresaId { get; set; }

    public string? Rut { get; set; }

    public int RutCuerpo { get; set; }

    public string RutDigito { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Email { get; set; }

    public short? RegionCodigo { get; set; }

    public short? CiudadCodigo { get; set; }

    public short? ComunaCodigo { get; set; }

    public string? Direccion { get; set; }

    public long? Telefono { get; set; }

    public long? Celular { get; set; }

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    public virtual Comuna? Comuna { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;
}
