using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Solicitud
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid SolicitanteId { get; set; }

    public Guid ProgramaId { get; set; }

    public int EstadoSolicitudCodigo { get; set; }

    public int Numero { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public string? Observaciones { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual CentroCosto CentroCosto { get; set; } = null!;

    public virtual ICollection<Cotizacion> Cotizacions { get; set; } = new List<Cotizacion>();

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual EstadoSolicitud EstadoSolicitudCodigoNavigation { get; set; } = null!;

    public virtual FuncionarioEmpresa FuncionarioEmpresa { get; set; } = null!;

    public virtual Programa Programa { get; set; } = null!;

    public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; } = new List<SolicitudDetalle>();
}
