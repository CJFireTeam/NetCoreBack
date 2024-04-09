using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class FuncionarioEmpresa
{
    public Guid EmpresaId { get; set; }

    public Guid FuncionarioId { get; set; }

    public int? GradoCertificadoProfesionalCodigo { get; set; }

    public string? FormacionProfesional { get; set; }

    public string? Funcion { get; set; }

    public decimal? Puntaje { get; set; }

    public bool Activo { get; set; }

    public decimal? Saldo { get; set; }

    public string? Titulo { get; set; }

    public string? InstitucionAcademica { get; set; }

    public string? EstadoAcreditacionInstitucion { get; set; }

    public string? MetodoVerificacionEducacion { get; set; }

    public DateTime? FechaGraduacion { get; set; }

    public bool PagarAlumnosPrioritarios { get; set; }

    public Guid? ReliquidacionId { get; set; }

    public int? NumeroBienioReliquidado { get; set; }

    public bool BrpTitulo { get; set; }

    public bool BrpMencion { get; set; }

    public int? TituloCodigo { get; set; }

    public int? UnidadFuncionalCodigo { get; set; }

    public int? PostTituloCodigo { get; set; }

    public int? EspecialidadCodigo { get; set; }

    public DateTime? InicioNombramientoContrata { get; set; }

    public DateTime? InicioNombramientoTitular { get; set; }

    public DateTime? TerminoNombramiento { get; set; }

    public DateTime? IngresoServicio { get; set; }

    public DateTime? FechaInicioCalidadJuridicaContrata { get; set; }

    public DateTime? FechaInicioCalidadJuridicaPlanta { get; set; }

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    public virtual ICollection<Comprobante> Comprobantes { get; set; } = new List<Comprobante>();

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual Especialidad? EspecialidadCodigoNavigation { get; set; }

    public virtual Funcionario Funcionario { get; set; } = null!;

    public virtual Persona FuncionarioNavigation { get; set; } = null!;

    public virtual GradoCertificadoProfesional? GradoCertificadoProfesionalCodigoNavigation { get; set; }

    public virtual ICollection<OrdenCompra> OrdenCompras { get; set; } = new List<OrdenCompra>();

    public virtual PostTitulo? PostTituloCodigoNavigation { get; set; }

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual Titulo? TituloCodigoNavigation { get; set; }

    public virtual UnidadFuncional? UnidadFuncionalCodigoNavigation { get; set; }
}
