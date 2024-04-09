using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Contacto
{
    public Guid Id { get; set; }

    public Guid ProveedorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Cargo { get; set; }

    public int? TelefonoNumero { get; set; }

    public int? CelularNumero { get; set; }

    public string? Email { get; set; }

    public string? Observacion { get; set; }

    public virtual ICollection<Cotizacion> Cotizacions { get; set; } = new List<Cotizacion>();

    public virtual Proveedor Proveedor { get; set; } = null!;
}
