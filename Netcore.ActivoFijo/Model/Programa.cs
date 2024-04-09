using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Programa
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public long Numero { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Sigla { get; set; }

    public int AmbitoCodigo { get; set; }

    public decimal? PresupuestoMonto { get; set; }

    public decimal? PresupuestoRestante { get; set; }

    public bool ProgramaSep { get; set; }

    public bool ProgramaPie { get; set; }

    public bool GastoCorriente { get; set; }

    public Guid DepartamentoId { get; set; }

    public Guid UnidadId { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    public virtual Departamento Departamento { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();
}
