using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Recepcion
{
    public Guid CotizacionId { get; set; }

    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid? BodegaId { get; set; }

    public Guid FuncionarioId { get; set; }

    public int TipoDocumentoRecepcionCodigo { get; set; }

    public int NumeroDocumento { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaRecepcion { get; set; }

    public string? Observaciones { get; set; }

    public int? NumeroRecepcion { get; set; }

    public DateTime FechaDocumento { get; set; }

    public bool Nula { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual CentroCosto CentroCosto { get; set; } = null!;

    public virtual Cotizacion Cotizacion { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual FuncionarioEmpresa FuncionarioEmpresa { get; set; } = null!;

    public virtual OrdenCompra OrdenCompra { get; set; } = null!;

    public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; } = new List<RecepcionDetalle>();

    public virtual TipoDocumentoRecepcion TipoDocumentoRecepcionCodigoNavigation { get; set; } = null!;
}
