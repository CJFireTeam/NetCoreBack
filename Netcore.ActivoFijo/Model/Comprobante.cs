using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Comprobante
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public Guid? UnidadId { get; set; }

    public Guid? DepartamentoId { get; set; }

    public Guid FuncionarioId { get; set; }

    public int ComprobanteTipoCodigo { get; set; }

    public int EstadoComprobanteCodigo { get; set; }

    public DateTime Fecha { get; set; }

    public int Numero { get; set; }

    public decimal TotalDebe { get; set; }

    public decimal TotalHaber { get; set; }

    public string? GlosaGlobal { get; set; }

    public int? MesNumero { get; set; }

    public bool Remuneracion { get; set; }

    public bool Honorario { get; set; }

    public bool Apertura { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    public virtual ComprobanteTipo ComprobanteTipoCodigoNavigation { get; set; } = null!;

    public virtual Departamento? Departamento { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual EstadoComprobante EstadoComprobanteCodigoNavigation { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual FuncionarioEmpresa FuncionarioEmpresa { get; set; } = null!;

    public virtual Periodo? Periodo { get; set; }
}
