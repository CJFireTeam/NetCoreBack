using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Model;

public partial class Context : DbContext
{
    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ActividadEconomica> ActividadEconomicas { get; set; }

    public virtual DbSet<ActividadEconomicaPrincipal> ActividadEconomicaPrincipals { get; set; }

    public virtual DbSet<Almacen> Almacens { get; set; }

    public virtual DbSet<AlmacenArticulo> AlmacenArticulos { get; set; }

    public virtual DbSet<Ano> Anos { get; set; }

    public virtual DbSet<AnoMe> AnoMes { get; set; }

    public virtual DbSet<AreaGeografica> AreaGeograficas { get; set; }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<ArticuloValor> ArticuloValors { get; set; }

    public virtual DbSet<Bodega> Bodegas { get; set; }

    public virtual DbSet<CentroCosto> CentroCostos { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Comprobante> Comprobantes { get; set; }

    public virtual DbSet<ComprobanteDetalle> ComprobanteDetalles { get; set; }

    public virtual DbSet<ComprobanteTipo> ComprobanteTipos { get; set; }

    public virtual DbSet<Comuna> Comunas { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Cotizacion> Cotizacions { get; set; }

    public virtual DbSet<CotizacionDetalle> CotizacionDetalles { get; set; }

    public virtual DbSet<CuentaCorriente> CuentaCorrientes { get; set; }

    public virtual DbSet<Cuentum> Cuenta { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<EstadoArticulo> EstadoArticulos { get; set; }

    public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }

    public virtual DbSet<EstadoComprobante> EstadoComprobantes { get; set; }

    public virtual DbSet<EstadoCotizacion> EstadoCotizacions { get; set; }

    public virtual DbSet<EstadoSolicitud> EstadoSolicituds { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Familium> Familia { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<FuncionarioEmpresa> FuncionarioEmpresas { get; set; }

    public virtual DbSet<GradoCertificadoProfesional> GradoCertificadoProfesionals { get; set; }

    public virtual DbSet<InstitucionValorSeguro> InstitucionValorSeguros { get; set; }

    public virtual DbSet<Locacion> Locacions { get; set; }

    public virtual DbSet<Me> Mes { get; set; }

    public virtual DbSet<Nacionalidad> Nacionalidads { get; set; }

    public virtual DbSet<NivelEducacional> NivelEducacionals { get; set; }

    public virtual DbSet<OrdenCompra> OrdenCompras { get; set; }

    public virtual DbSet<OrdenCompraDetalle> OrdenCompraDetalles { get; set; }

    public virtual DbSet<ParteEntradum> ParteEntrada { get; set; }

    public virtual DbSet<ParteSalidum> ParteSalida { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<PostTitulo> PostTitulos { get; set; }

    public virtual DbSet<Programa> Programas { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<PuebloIndigena> PuebloIndigenas { get; set; }

    public virtual DbSet<Recepcion> Recepcions { get; set; }

    public virtual DbSet<RecepcionDetalle> RecepcionDetalles { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<SectorActividadEconomica> SectorActividadEconomicas { get; set; }

    public virtual DbSet<Sexo> Sexos { get; set; }

    public virtual DbSet<Solicitud> Solicituds { get; set; }

    public virtual DbSet<SolicitudDetalle> SolicitudDetalles { get; set; }

    public virtual DbSet<SubFamilium> SubFamilia { get; set; }

    public virtual DbSet<SucursalBancarium> SucursalBancaria { get; set; }

    public virtual DbSet<TipoAdministracion> TipoAdministracions { get; set; }

    public virtual DbSet<TipoAlmacen> TipoAlmacens { get; set; }

    public virtual DbSet<TipoCuentaEstadoResultado> TipoCuentaEstadoResultados { get; set; }

    public virtual DbSet<TipoCuentum> TipoCuenta { get; set; }

    public virtual DbSet<TipoCuentum1> TipoCuenta1 { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoDocumentoFactura> TipoDocumentoFacturas { get; set; }

    public virtual DbSet<TipoDocumentoRecepcion> TipoDocumentoRecepcions { get; set; }

    public virtual DbSet<TipoEstablecimientoSalud> TipoEstablecimientoSaluds { get; set; }

    public virtual DbSet<TipoGastoOperacional> TipoGastoOperacionals { get; set; }

    public virtual DbSet<TipoIngresoOperacional> TipoIngresoOperacionals { get; set; }

    public virtual DbSet<TipoInstitucionValorSeguro> TipoInstitucionValorSeguros { get; set; }

    public virtual DbSet<TipoLocacion> TipoLocacions { get; set; }

    public virtual DbSet<TipoUnidad> TipoUnidads { get; set; }

    public virtual DbSet<Titulo> Titulos { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<UnidadFuncional> UnidadFuncionals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActividadEconomica>(entity =>
        {
            entity.HasKey(e => new { e.ActividadEconomicaPrincipalCodigo, e.SectorActividadEconomicaCodigo, e.Codigo });

            entity.ToTable("ActividadEconomica");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.SectorActividadEconomica).WithMany(p => p.ActividadEconomicas)
                .HasForeignKey(d => new { d.ActividadEconomicaPrincipalCodigo, d.SectorActividadEconomicaCodigo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActividadEconomica_SectorActividadEconomica");
        });

        modelBuilder.Entity<ActividadEconomicaPrincipal>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("ActividadEconomicaPrincipal");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Almacen>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CentroCostoId, e.BodegaId, e.Id });

            entity.ToTable("Almacen", "Inventario");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoAlmacen).WithMany(p => p.Almacens)
                .HasForeignKey(d => d.TipoAlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Almacen_TipoAlmacen");

            entity.HasOne(d => d.Bodega).WithMany(p => p.Almacens)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId, d.BodegaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Almacen_Bodega");
        });

        modelBuilder.Entity<AlmacenArticulo>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CentroCostoId, e.BodegaId, e.AlmacenId, e.AnoNumero, e.SubFamiliaId, e.ArticuloId, e.EstadoArticuloCodigo });

            entity.ToTable("AlmacenArticulo", "Inventario");

            entity.Property(e => e.AlmacenId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.EstadoArticuloCodigoNavigation).WithMany(p => p.AlmacenArticulos)
                .HasForeignKey(d => d.EstadoArticuloCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlmacenArticulo_EstadoArticulo");

            entity.HasOne(d => d.Locacion).WithMany(p => p.AlmacenArticulos)
                .HasForeignKey(d => new { d.EmpresaId, d.LocacionId })
                .HasConstraintName("FK_AlmacenArticulo_Locacion");

            entity.HasOne(d => d.Articulo).WithMany(p => p.AlmacenArticulos)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SubFamiliaId, d.ArticuloId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlmacenArticulo_Articulo");

            entity.HasOne(d => d.Almacen).WithMany(p => p.AlmacenArticulos)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId, d.BodegaId, d.AlmacenId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlmacenArticulo_Almacen");
        });

        modelBuilder.Entity<Ano>(entity =>
        {
            entity.HasKey(e => e.Numero);

            entity.ToTable("Ano");

            entity.Property(e => e.Numero).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnoMe>(entity =>
        {
            entity.HasKey(e => new { e.AnoNumero, e.MesNumero });

            entity.Property(e => e.Inicio).HasColumnType("date");
            entity.Property(e => e.Termino).HasColumnType("date");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.AnoMes)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnoMes_Ano");

            entity.HasOne(d => d.MesNumeroNavigation).WithMany(p => p.AnoMes)
                .HasForeignKey(d => d.MesNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnoMes_Mes");
        });

        modelBuilder.Entity<AreaGeografica>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("AreaGeografica");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.SubFamiliaId, e.Id });

            entity.ToTable("Articulo", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Codigo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Articulo_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Articulo_Empresa");

            entity.HasOne(d => d.TipoUnidadCodigoNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.TipoUnidadCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Articulo_TipoUnidad");

            entity.HasOne(d => d.SubFamilium).WithMany(p => p.Articulos)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SubFamiliaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Articulo_SubFamilia");
        });

        modelBuilder.Entity<ArticuloValor>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.SubFamiliaId, e.ArticuloId, e.Id });

            entity.ToTable("ArticuloValor", "Inventario");

            entity.Property(e => e.ArticuloId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Articulo).WithMany(p => p.ArticuloValors)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SubFamiliaId, d.ArticuloId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArticuloValor_Articulo");
        });

        modelBuilder.Entity<Bodega>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CentroCostoId, e.Id }).HasName("PK_Bodega_1");

            entity.ToTable("Bodega", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sigla)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Empresa).WithMany(p => p.Bodegas)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bodega_Empresa");

            entity.HasOne(d => d.CentroCosto).WithMany(p => p.Bodegas)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bodega_CentroCosto");
        });

        modelBuilder.Entity<CentroCosto>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.Id });

            entity.ToTable("CentroCosto");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodigoContabilidad)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodigoDipres)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodigoDIPRES");
            entity.Property(e => e.CodigoPrevired)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.RutaReporte)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sigla)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Administrador).WithMany(p => p.CentroCostos)
                .HasForeignKey(d => d.AdministradorId)
                .HasConstraintName("FK_CentroCosto_Administrador");

            entity.HasOne(d => d.AreaGeograficaCodigoNavigation).WithMany(p => p.CentroCostos)
                .HasForeignKey(d => d.AreaGeograficaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CentroCosto_AreaGeografica");

            entity.HasOne(d => d.Empresa).WithMany(p => p.CentroCostos)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CentroCosto_Empresa");

            entity.HasOne(d => d.TipoEstablecimientoSaludCodigoNavigation).WithMany(p => p.CentroCostos)
                .HasForeignKey(d => d.TipoEstablecimientoSaludCodigo)
                .HasConstraintName("FK_CentroCosto_TipoEstablecimientoSalud");

            entity.HasOne(d => d.CentroCostoNavigation).WithMany(p => p.InverseCentroCostoNavigation)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId })
                .HasConstraintName("FK_Anexo_CentroCostoPadre");

            entity.HasOne(d => d.Departamento).WithMany(p => p.CentroCostos)
                .HasForeignKey(d => new { d.EmpresaId, d.UnidadId, d.DepartamentoId })
                .HasConstraintName("FK_CentroCosto_Departamento");

            entity.HasOne(d => d.Comuna).WithMany(p => p.CentroCostos)
                .HasForeignKey(d => new { d.RegionCodigo, d.CiudadCodigo, d.ComunaCodigo })
                .HasConstraintName("FK_CentroCosto_Comuna");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => new { e.RegionCodigo, e.Codigo });

            entity.ToTable("Ciudad");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.RegionCodigoNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.RegionCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ciudad_Region");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EmpresaId });

            entity.ToTable("Cliente");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rut)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([varchar],([dbo].[FormatInt]([RutCuerpo])+'-')+[RutDigito],(0)))", false);
            entity.Property(e => e.RutDigito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Empresa).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cliente_Empresa");

            entity.HasOne(d => d.Comuna).WithMany(p => p.Clientes)
                .HasForeignKey(d => new { d.RegionCodigo, d.CiudadCodigo, d.ComunaCodigo })
                .HasConstraintName("FK_Cliente_Comuna");
        });

        modelBuilder.Entity<Comprobante>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.Id }).HasName("PK_Comprobante_1");

            entity.ToTable("Comprobante", "Contabilidad");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FuncionarioId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GlosaGlobal).HasColumnType("text");
            entity.Property(e => e.TotalDebe).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalHaber).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comprobante_Ano");

            entity.HasOne(d => d.ComprobanteTipoCodigoNavigation).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => d.ComprobanteTipoCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comprobante_ComprobanteTipo");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comprobante_Empresa");

            entity.HasOne(d => d.EstadoComprobanteCodigoNavigation).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => d.EstadoComprobanteCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comprobante_EstadoComprobante");

            entity.HasOne(d => d.FuncionarioEmpresa).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => new { d.EmpresaId, d.FuncionarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comprobante_FuncionarioEmpresa");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.MesNumero })
                .HasConstraintName("FK_Comprobante_Periodo");

            entity.HasOne(d => d.Departamento).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => new { d.EmpresaId, d.UnidadId, d.DepartamentoId })
                .HasConstraintName("FK_Comprobante_Departamento");
        });

        modelBuilder.Entity<ComprobanteDetalle>(entity =>
        {
            entity.HasKey(e => new { e.ComprobanteId, e.AnoNumero, e.EmpresaId, e.Id }).HasName("PK_ComprobanteDetalle_1");

            entity.ToTable("ComprobanteDetalle", "Contabilidad");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FechaDocumento).HasColumnType("date");
            entity.Property(e => e.FechaVencimiento).HasColumnType("date");
            entity.Property(e => e.Glosa).IsUnicode(false);
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobanteDetalle_Ano");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_ComprobanteDetalle_Proveedor");

            entity.HasOne(d => d.TipoDocumentoCodigoNavigation).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => d.TipoDocumentoCodigo)
                .HasConstraintName("FK_ComprobanteDetalle_TipoDocumento");

            entity.HasOne(d => d.Cliente).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => new { d.ClienteId, d.EmpresaId })
                .HasConstraintName("FK_ComprobanteDetalle_Cliente");

            entity.HasOne(d => d.CentroCosto).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobanteDetalle_CentroCosto");

            entity.HasOne(d => d.FuncionarioEmpresa).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.FuncionarioId })
                .HasConstraintName("FK_ComprobanteDetalle_FuncionarioEmpresa");

            entity.HasOne(d => d.Cuentum).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => new { d.CuentaId, d.AnoNumero, d.EmpresaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobanteDetalle_Cuenta");

            entity.HasOne(d => d.Comprobante).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.ComprobanteId })
                .HasConstraintName("FK_ComprobanteDetalle_Comprobante");

            entity.HasOne(d => d.Programa).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.ProgramaId })
                .HasConstraintName("FK_ComprobanteDetalle_Programa");

            entity.HasOne(d => d.CuentaCorriente).WithMany(p => p.ComprobanteDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SucursalBancariaId, d.CuentaCorrienteId })
                .HasConstraintName("FK_ComprobanteDetalle_CuentaCorriente");
        });

        modelBuilder.Entity<ComprobanteTipo>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("ComprobanteTipo", "Contabilidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Comuna>(entity =>
        {
            entity.HasKey(e => new { e.RegionCodigo, e.CiudadCodigo, e.Codigo });

            entity.ToTable("Comuna");

            entity.Property(e => e.CodigoDipres)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CodigoDIPRES");
            entity.Property(e => e.CodigoLre).HasColumnName("CodigoLRE");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Ciudad).WithMany(p => p.Comunas)
                .HasForeignKey(d => new { d.RegionCodigo, d.CiudadCodigo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comuna_Ciudad");
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.ToTable("Contacto");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observacion).HasColumnType("text");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacto_Proveedor");
        });

        modelBuilder.Entity<Cotizacion>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.Id }).HasName("PK_Cotizacion_1");

            entity.ToTable("Cotizacion", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FechaEntrega).HasColumnType("date");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.ValorNeto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cotizacion_Ano");

            entity.HasOne(d => d.Contacto).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => d.ContactoId)
                .HasConstraintName("FK_Cotizacion_Contacto");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cotizacion_Empresa");

            entity.HasOne(d => d.EstadoCotizacionCodigoNavigation).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => d.EstadoCotizacionCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cotizacion_EstadoCotizacion");

            entity.HasOne(d => d.FormaPagoCodigoNavigation).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => d.FormaPagoCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cotizacion_FormaPago");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cotizacion_Proveedor");

            entity.HasOne(d => d.Solicitud).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SolicitudId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cotizacion_Solicitud");
        });

        modelBuilder.Entity<CotizacionDetalle>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CotizacionId, e.AnoNumero, e.Id });

            entity.ToTable("CotizacionDetalle", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.SolicitudDetalleId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ValorUnitario).HasColumnType("decimal(18, 3)");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.CotizacionDetalles)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CotizacionDetalle_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.CotizacionDetalles)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CotizacionDetalle_Empresa");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.CotizacionDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.CotizacionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CotizacionDetalle_Cotizacion");

            entity.HasOne(d => d.SubFamilium).WithMany(p => p.CotizacionDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SubFamiliaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CotizacionDetalle_SubFamilia");

            entity.HasOne(d => d.Articulo).WithMany(p => p.CotizacionDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SubFamiliaId, d.ArticuloId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CotizacionDetalle_Articulo");

            entity.HasOne(d => d.SolicitudDetalle).WithMany(p => p.CotizacionDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.SolicitudId, d.AnoNumero, d.SolicitudDetalleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CotizacionDetalle_SolicitudDetalle");
        });

        modelBuilder.Entity<CuentaCorriente>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.SucursalBancariaId, e.Id });

            entity.ToTable("CuentaCorriente", "Contabilidad");

            entity.Property(e => e.EmpresaId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Saldo).HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.CuentaCorrientes)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaCorriente_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.CuentaCorrientes)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaCorriente_Empresa");

            entity.HasOne(d => d.SucursalBancarium).WithMany(p => p.CuentaCorrientes)
                .HasForeignKey(d => new { d.EmpresaId, d.SucursalBancariaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaCorriente_SucursalBancaria");

            entity.HasOne(d => d.Cuentum).WithMany(p => p.CuentaCorrientes)
                .HasForeignKey(d => new { d.CuentaId, d.AnoNumero, d.EmpresaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaCorriente_Cuenta");
        });

        modelBuilder.Entity<Cuentum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.AnoNumero, e.EmpresaId });

            entity.ToTable("Cuenta", "Contabilidad");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresupuestoInicial).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PresupuestoVigente).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cuenta_Ano");

            entity.HasOne(d => d.TipoCuentaCodigoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.TipoCuentaCodigo)
                .HasConstraintName("FK_Cuenta_TipoCuenta");

            entity.HasOne(d => d.TipoCuentaEstadoResultadoCodigoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.TipoCuentaEstadoResultadoCodigo)
                .HasConstraintName("FK_Cuenta_TipoCuentaEstadoResultado");

            entity.HasOne(d => d.TipoGastoOperacionalCodigoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.TipoGastoOperacionalCodigo)
                .HasConstraintName("FK_Cuenta_TipoGastoOperacional");

            entity.HasOne(d => d.TipoIngresoOperacionalCodigoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.TipoIngresoOperacionalCodigo)
                .HasConstraintName("FK_Cuenta_TipoIngresoOperacional");

            entity.HasOne(d => d.CuentumNavigation).WithMany(p => p.InverseCuentumNavigation)
                .HasForeignKey(d => new { d.CuentaId, d.AnoNumero, d.EmpresaId })
                .HasConstraintName("FK_Hijo_Padre");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.UnidadId, e.Id });

            entity.ToTable("Departamento");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Clave)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.HasOne(d => d.Administrador).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.AdministradorId)
                .HasConstraintName("FK_Departamento_Administrador");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Departamento_Empresa");

            entity.HasOne(d => d.Unidad).WithMany(p => p.Departamentos)
                .HasForeignKey(d => new { d.EmpresaId, d.UnidadId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Departamento_Unidad");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.ToTable("Empresa");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.GerenteRrhhid).HasColumnName("GerenteRRHHId");
            entity.Property(e => e.Giro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaginaWeb)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.PieFirmaLiquidacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial).IsUnicode(false);
            entity.Property(e => e.Rut)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([varchar],([dbo].[FormatInt]([RutCuerpo])+'-')+[RutDigito],(0)))", false);
            entity.Property(e => e.RutDigito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RutaReporte)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Administrador).WithMany(p => p.EmpresaAdministradors)
                .HasForeignKey(d => d.AdministradorId)
                .HasConstraintName("FK_Empresa_Administrador");

            entity.HasOne(d => d.GerenteRrhh).WithMany(p => p.EmpresaGerenteRrhhs)
                .HasForeignKey(d => d.GerenteRrhhid)
                .HasConstraintName("FK_Empresa_GerenteRRHH");

            entity.HasOne(d => d.TipoAdministracionCodigoNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.TipoAdministracionCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empresa_TipoAdministracion");

            entity.HasOne(d => d.ActividadEconomica).WithMany(p => p.Empresas)
                .HasForeignKey(d => new { d.ActividadEconomicaPrincipalCodigo, d.SectorActividadEconomicaCodigo, d.ActividadEconomicaCodigo })
                .HasConstraintName("FK_Empresa_ActividadEconomica");

            entity.HasOne(d => d.Comuna).WithMany(p => p.Empresas)
                .HasForeignKey(d => new { d.RegionCodigo, d.CiudadCodigo, d.ComunaCodigo })
                .HasConstraintName("FK_Empresa_Comuna");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_Especialidad_1");

            entity.ToTable("Especialidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.CodigoDipres)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CodigoDIPRES");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoArticulo>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("EstadoArticulo", "Inventario");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoCivil>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("EstadoCivil");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoComprobante>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("EstadoComprobante", "Contabilidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoCotizacion>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("EstadoCotizacion", "Adquisiciones");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoSolicitud>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("EstadoSolicitud", "Adquisiciones");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CotizacionId, e.AnoNumero, e.Id });

            entity.ToTable("Factura", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.ValorNeto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Factura_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Factura_Empresa");

            entity.HasOne(d => d.TipoDocumentoRecepcionCodigoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.TipoDocumentoRecepcionCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Factura_TipoDocumentoFactura");

            entity.HasOne(d => d.CentroCosto).WithMany(p => p.Facturas)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Factura_CentroCosto");

            entity.HasOne(d => d.Cuentum).WithMany(p => p.Facturas)
                .HasForeignKey(d => new { d.CuentaProveedorId, d.AnoNumero, d.EmpresaId })
                .HasConstraintName("FK_Factura_CuentaProveedor");

            entity.HasOne(d => d.Comprobante).WithMany(p => p.Facturas)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.ComprobanteId })
                .HasConstraintName("FK_Factura_Comprobante");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.Facturas)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.CotizacionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Factura_Cotizacion");

            entity.HasOne(d => d.Programa).WithMany(p => p.Facturas)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.ProgramaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Factura_Programa");

            entity.HasOne(d => d.OrdenCompra).WithMany(p => p.Facturas)
                .HasForeignKey(d => new { d.EmpresaId, d.CotizacionId, d.AnoNumero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Factura_OrdenCompra");
        });

        modelBuilder.Entity<Familium>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.Id }).HasName("PK_Familia_1");

            entity.ToTable("Familia", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .IsUnicode(false);

            entity.HasOne(d => d.FamiliumNavigation).WithMany(p => p.InverseFamiliumNavigation)
                .HasForeignKey(d => new { d.EmpresaId, d.FamiliaId })
                .HasConstraintName("FK_Hijo_Padre");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("FormaPago", "Adquisiciones");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.ToTable("Funcionario", "Dotacion");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PagoAtdp).HasColumnName("PagoATDP");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Funcionario)
                .HasForeignKey<Funcionario>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Funcionario_Persona");
        });

        modelBuilder.Entity<FuncionarioEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.FuncionarioId });

            entity.ToTable("FuncionarioEmpresa", "Dotacion");

            entity.Property(e => e.EstadoAcreditacionInstitucion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FechaGraduacion).HasColumnType("date");
            entity.Property(e => e.FechaInicioCalidadJuridicaContrata).HasColumnType("date");
            entity.Property(e => e.FechaInicioCalidadJuridicaPlanta).HasColumnType("date");
            entity.Property(e => e.FormacionProfesional)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Funcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.IngresoServicio).HasColumnType("date");
            entity.Property(e => e.InicioNombramientoContrata).HasColumnType("date");
            entity.Property(e => e.InicioNombramientoTitular).HasColumnType("date");
            entity.Property(e => e.InstitucionAcademica)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.MetodoVerificacionEducacion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Puntaje).HasColumnType("decimal(5, 1)");
            entity.Property(e => e.Saldo).HasColumnType("decimal(5, 1)");
            entity.Property(e => e.TerminoNombramiento).HasColumnType("date");
            entity.Property(e => e.Titulo)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.Empresa).WithMany(p => p.FuncionarioEmpresas)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FuncionarioEmpresa_Empresa");

            entity.HasOne(d => d.EspecialidadCodigoNavigation).WithMany(p => p.FuncionarioEmpresas)
                .HasForeignKey(d => d.EspecialidadCodigo)
                .HasConstraintName("FK_FuncionarioEmpresa_Especialidad");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.FuncionarioEmpresas)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK_FuncionarioEmpresa_Funcionario");

            entity.HasOne(d => d.FuncionarioNavigation).WithMany(p => p.FuncionarioEmpresas)
                .HasForeignKey(d => d.FuncionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FuncionarioEmpresa_Persona");

            entity.HasOne(d => d.GradoCertificadoProfesionalCodigoNavigation).WithMany(p => p.FuncionarioEmpresas)
                .HasForeignKey(d => d.GradoCertificadoProfesionalCodigo)
                .HasConstraintName("FK_FuncionarioEmpresa_GradoCertificadoProfesional");

            entity.HasOne(d => d.PostTituloCodigoNavigation).WithMany(p => p.FuncionarioEmpresas)
                .HasForeignKey(d => d.PostTituloCodigo)
                .HasConstraintName("FK_FuncionarioEmpresa_PostTitulo");

            entity.HasOne(d => d.TituloCodigoNavigation).WithMany(p => p.FuncionarioEmpresas)
                .HasForeignKey(d => d.TituloCodigo)
                .HasConstraintName("FK_FuncionarioEmpresa_TituloDipres");

            entity.HasOne(d => d.UnidadFuncionalCodigoNavigation).WithMany(p => p.FuncionarioEmpresas)
                .HasForeignKey(d => d.UnidadFuncionalCodigo)
                .HasConstraintName("FK_FuncionarioEmpresa_UnidadFuncional");
        });

        modelBuilder.Entity<GradoCertificadoProfesional>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_GradoTipoCertificado");

            entity.ToTable("GradoCertificadoProfesional", "Dotacion");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InstitucionValorSeguro>(entity =>
        {
            entity.HasKey(e => new { e.TipoInstitucionValorSeguroCodigo, e.Codigo }).HasName("PK_InstitucionValorSeguro_1");

            entity.ToTable("InstitucionValorSeguro");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoInstitucionValorSeguroCodigoNavigation).WithMany(p => p.InstitucionValorSeguros)
                .HasForeignKey(d => d.TipoInstitucionValorSeguroCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InstitucionValorSeguro_TipoInstitucionValorSeguro");
        });

        modelBuilder.Entity<Locacion>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.Id });

            entity.ToTable("Locacion", "Inventario");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoLocacion).WithMany(p => p.Locacions)
                .HasForeignKey(d => new { d.EmpresaId, d.TipoLocacionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locacion_TipoLocacion");

            entity.HasOne(d => d.Almacen).WithMany(p => p.Locacions)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId, d.BodegaId, d.AlmacenId })
                .HasConstraintName("FK_Locacion_Almacen");
        });

        modelBuilder.Entity<Me>(entity =>
        {
            entity.HasKey(e => e.Numero);

            entity.Property(e => e.Numero).ValueGeneratedNever();
            entity.Property(e => e.Inicial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Nacionalidad>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("Nacionalidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.CodigoDipres).HasColumnName("CodigoDIPRES");
            entity.Property(e => e.CodigoPais)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NivelEducacional>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("NivelEducacional");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.CodigoDipres)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CodigoDIPRES");
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenCompra>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CotizacionId, e.AnoNumero });

            entity.ToTable("OrdenCompra", "Adquisiciones");

            entity.Property(e => e.DireccionEnvio).HasColumnType("text");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.ValorNeto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ValorNetoDescuento).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_Empresa");

            entity.HasOne(d => d.FormaPagoCodigoNavigation).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.FormaPagoCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_FormaPago");

            entity.HasOne(d => d.FuncionarioEmpresa).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => new { d.EmpresaId, d.FuncionarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_Comprador");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.CotizacionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_Cotizacion");
        });

        modelBuilder.Entity<OrdenCompraDetalle>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CotizacionId, e.AnoNumero, e.CotizacionDetalleId });

            entity.ToTable("OrdenCompraDetalle", "Adquisiciones");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.OrdenCompraDetalles)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraDetalle_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.OrdenCompraDetalles)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraDetalle_Empresa");

            entity.HasOne(d => d.OrdenCompra).WithMany(p => p.OrdenCompraDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.CotizacionId, d.AnoNumero })
                .HasConstraintName("FK_OrdenCompraDetalle_OrdenCompra");

            entity.HasOne(d => d.CotizacionDetalle).WithOne(p => p.OrdenCompraDetalle)
                .HasForeignKey<OrdenCompraDetalle>(d => new { d.EmpresaId, d.CotizacionId, d.AnoNumero, d.CotizacionDetalleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraDetalle_CotizacionDetalle");
        });

        modelBuilder.Entity<ParteEntradum>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CentroCostoId, e.BodegaId, e.AlmacenId, e.AnoNumero, e.SubFamiliaId, e.ArticuloId, e.EstadoArticuloCodigo, e.Id });

            entity.ToTable("ParteEntrada", "Inventario");

            entity.Property(e => e.AlmacenId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.RecepcionDetalle).WithMany(p => p.ParteEntrada)
                .HasForeignKey(d => new { d.RecepcionId, d.CotizacionId, d.EmpresaId, d.CotizacionDetalleId, d.AnoNumero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParteEntrada_RecepcionDetalle1");

            entity.HasOne(d => d.AlmacenArticulo).WithMany(p => p.ParteEntrada)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId, d.BodegaId, d.AlmacenId, d.AnoNumero, d.SubFamiliaId, d.ArticuloId, d.EstadoArticuloCodigo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParteEntrada_AlmacenArticulo");
        });

        modelBuilder.Entity<ParteSalidum>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.CentroCostoId, e.BodegaId, e.AlmacenId, e.AnoNumero, e.SubFamiliaId, e.ArticuloId, e.EstadoArticuloCodigo, e.Id }).HasName("PK_ParteSalida_1");

            entity.ToTable("ParteSalida", "Inventario");

            entity.Property(e => e.AlmacenId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Articulo).WithMany(p => p.ParteSalida)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SubFamiliaId, d.ArticuloId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParteSalida_Articulo");

            entity.HasOne(d => d.AlmacenArticulo).WithMany(p => p.ParteSalida)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId, d.BodegaId, d.AlmacenId, d.AnoNumero, d.SubFamiliaId, d.ArticuloId, d.EstadoArticuloCodigo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParteSalida_AlmacenArticulo");
        });

        modelBuilder.Entity<Periodo>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.MesNumero }).HasName("PK_Periodo_1");

            entity.ToTable("Periodo", "Dotacion");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Empresa).WithMany(p => p.Periodos)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Periodo_Empresa");

            entity.HasOne(d => d.AnoMe).WithMany(p => p.Periodos)
                .HasForeignKey(d => new { d.AnoNumero, d.MesNumero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Periodo_AnoMes");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.ToTable("Persona");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.DireccionLaboral).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.FechaNacimiento).HasColumnType("date");
            entity.Property(e => e.Huella).HasColumnType("image");
            entity.Property(e => e.ImagenHuella).HasColumnType("image");
            entity.Property(e => e.Nombre)
                .HasMaxLength(95)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([varchar](95),(((rtrim(ltrim([ApellidoPaterno]))+' ')+isnull(rtrim(ltrim([ApellidoMaterno])),''))+', ')+rtrim(ltrim([Nombres])),(0)))", false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.NroDepartamento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Run)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([varchar],([dbo].[FormatInt]([RunCuerpo])+'-')+[RunDigito],(0)))", false);
            entity.Property(e => e.RunDigito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VillaPoblacion)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.AreaGeograficaCodigoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.AreaGeograficaCodigo)
                .HasConstraintName("FK_Persona_AreaGeografica");

            entity.HasOne(d => d.EstadoCivilCodigoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.EstadoCivilCodigo)
                .HasConstraintName("FK_Persona_EstadoCivil");

            entity.HasOne(d => d.NacionalidadCodigoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.NacionalidadCodigo)
                .HasConstraintName("FK_Persona_Nacionalidad");

            entity.HasOne(d => d.NivelEducacionalCodigoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.NivelEducacionalCodigo)
                .HasConstraintName("FK_Persona_NivelEducacional");

            entity.HasOne(d => d.SexoCodigoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.SexoCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Persona_Sexo");

            entity.HasOne(d => d.Comuna).WithMany(p => p.PersonaComunas)
                .HasForeignKey(d => new { d.RegionCodigo, d.CiudadCodigo, d.ComunaCodigo })
                .HasConstraintName("FK_Persona_Comuna");

            entity.HasOne(d => d.ComunaNavigation).WithMany(p => p.PersonaComunaNavigations)
                .HasForeignKey(d => new { d.RegionNacimientoCodigo, d.CiudadNacimientoCodigo, d.ComunaNacimientoCodigo })
                .HasConstraintName("FK_Persona_ComunaNacimiento");
        });

        modelBuilder.Entity<PostTitulo>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("PostTitulo");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Programa>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.Id });

            entity.ToTable("Programa", "Contabilidad");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PresupuestoMonto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PresupuestoRestante).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProgramaPie).HasColumnName("ProgramaPIE");
            entity.Property(e => e.ProgramaSep).HasColumnName("ProgramaSEP");
            entity.Property(e => e.Sigla)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.Programas)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programa_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Programas)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programa_Empresa");

            entity.HasOne(d => d.Departamento).WithMany(p => p.Programas)
                .HasForeignKey(d => new { d.EmpresaId, d.UnidadId, d.DepartamentoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programa_Departamento");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Proveedor_1");

            entity.ToTable("Proveedor");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PaginaWeb)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial).IsUnicode(false);
            entity.Property(e => e.Rut)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([varchar],([dbo].[FormatInt]([RutCuerpo])+'-')+[RutDigito],(0)))", false);
            entity.Property(e => e.RutDigito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.TipoCuentaCodigoNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.TipoCuentaCodigo)
                .HasConstraintName("FK_Proveedor_TipoCuenta");

            entity.HasOne(d => d.InstitucionValorSeguro).WithMany(p => p.Proveedors)
                .HasForeignKey(d => new { d.TipoInstitucionValorSeguroCodigo, d.InstitucionValorSeguroCodigo })
                .HasConstraintName("FK_Proveedor_InstitucionValorSeguro");
        });

        modelBuilder.Entity<PuebloIndigena>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("PuebloIndigena");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Recepcion>(entity =>
        {
            entity.HasKey(e => new { e.CotizacionId, e.EmpresaId, e.AnoNumero, e.Id });

            entity.ToTable("Recepcion", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FechaDocumento).HasColumnType("date");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaRecepcion).HasColumnType("date");
            entity.Property(e => e.Observaciones).HasColumnType("text");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.Recepcions)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcion_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Recepcions)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcion_Empresa");

            entity.HasOne(d => d.TipoDocumentoRecepcionCodigoNavigation).WithMany(p => p.Recepcions)
                .HasForeignKey(d => d.TipoDocumentoRecepcionCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcion_TipoDocumentoRecepcion");

            entity.HasOne(d => d.CentroCosto).WithMany(p => p.Recepcions)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcion_CentroCosto");

            entity.HasOne(d => d.FuncionarioEmpresa).WithMany(p => p.Recepcions)
                .HasForeignKey(d => new { d.EmpresaId, d.FuncionarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcion_FuncionarioEmpresa");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.Recepcions)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.CotizacionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcion_Cotizacion");

            entity.HasOne(d => d.OrdenCompra).WithMany(p => p.Recepcions)
                .HasForeignKey(d => new { d.EmpresaId, d.CotizacionId, d.AnoNumero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recepcion_OrdenCompra");
        });

        modelBuilder.Entity<RecepcionDetalle>(entity =>
        {
            entity.HasKey(e => new { e.RecepcionId, e.CotizacionId, e.EmpresaId, e.CotizacionDetalleId, e.AnoNumero }).HasName("PK_RecepcionDetalle_1");

            entity.ToTable("RecepcionDetalle", "Adquisiciones");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Observaciones).HasColumnType("text");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.RecepcionDetalles)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecepcionDetalle_Ano");

            entity.HasOne(d => d.Recepcion).WithMany(p => p.RecepcionDetalles)
                .HasForeignKey(d => new { d.CotizacionId, d.EmpresaId, d.AnoNumero, d.RecepcionId })
                .HasConstraintName("FK_RecepcionDetalle_Recepcion");

            entity.HasOne(d => d.OrdenCompraDetalle).WithMany(p => p.RecepcionDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.CotizacionId, d.AnoNumero, d.CotizacionDetalleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecepcionDetalle_OrdenCompraDetalle");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("Region");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreOficial)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SectorActividadEconomica>(entity =>
        {
            entity.HasKey(e => new { e.ActividadEconomicaPrincipalCodigo, e.Codigo });

            entity.ToTable("SectorActividadEconomica");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.ActividadEconomicaPrincipalCodigoNavigation).WithMany(p => p.SectorActividadEconomicas)
                .HasForeignKey(d => d.ActividadEconomicaPrincipalCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SectorActividadEconomica_ActividadEconomicaPrincipal");
        });

        modelBuilder.Entity<Sexo>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("Sexo");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Letra)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.Id }).HasName("PK_Solicitud_1");

            entity.ToTable("Solicitud", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FechaIngreso).HasColumnType("date");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_Empresa");

            entity.HasOne(d => d.EstadoSolicitudCodigoNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.EstadoSolicitudCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_EstadoSolicitud");

            entity.HasOne(d => d.CentroCosto).WithMany(p => p.Solicituds)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_CentroCosto");

            entity.HasOne(d => d.FuncionarioEmpresa).WithMany(p => p.Solicituds)
                .HasForeignKey(d => new { d.EmpresaId, d.SolicitanteId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_Solicitante");

            entity.HasOne(d => d.Programa).WithMany(p => p.Solicituds)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.ProgramaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_Programa");
        });

        modelBuilder.Entity<SolicitudDetalle>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.SolicitudId, e.AnoNumero, e.Id });

            entity.ToTable("SolicitudDetalle", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.CantidadAprobada).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Observaciones).HasColumnType("text");

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.SolicitudDetalles)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolicitudDetalle_Ano");

            entity.HasOne(d => d.CentroCosto).WithMany(p => p.SolicitudDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.CentroCostoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolicitudDetalle_CentroCosto");

            entity.HasOne(d => d.Solicitud).WithMany(p => p.SolicitudDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SolicitudId })
                .HasConstraintName("FK_SolicitudDetalle_Solicitud");

            entity.HasOne(d => d.Articulo).WithMany(p => p.SolicitudDetalles)
                .HasForeignKey(d => new { d.EmpresaId, d.AnoNumero, d.SubFamiliaId, d.ArticuloId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolicitudDetalle_Articulo");
        });

        modelBuilder.Entity<SubFamilium>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.AnoNumero, e.Id }).HasName("PK_SubFamilia_1");

            entity.ToTable("SubFamilia", "Adquisiciones");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.AnoNumeroNavigation).WithMany(p => p.SubFamilia)
                .HasForeignKey(d => d.AnoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubFamilia_Ano");

            entity.HasOne(d => d.Empresa).WithMany(p => p.SubFamilia)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubFamilia_Empresa");

            entity.HasOne(d => d.Cuentum).WithMany(p => p.SubFamiliumCuenta)
                .HasForeignKey(d => new { d.CuentaId, d.AnoNumero, d.EmpresaId })
                .HasConstraintName("FK_SubFamilia_Cuenta");

            entity.HasOne(d => d.CuentumNavigation).WithMany(p => p.SubFamiliumCuentumNavigations)
                .HasForeignKey(d => new { d.CuentaObligacionId, d.AnoNumero, d.EmpresaId })
                .HasConstraintName("FK_SubFamilia_CuentaObligacion");
        });

        modelBuilder.Entity<SucursalBancarium>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.Id });

            entity.ToTable("SucursalBancaria", "Contabilidad");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.Empresa).WithMany(p => p.SucursalBancaria)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SucursalBancaria_Empresa");

            entity.HasOne(d => d.InstitucionValorSeguro).WithMany(p => p.SucursalBancaria)
                .HasForeignKey(d => new { d.TipoInstitucionValorSeguroCodigo, d.InstitucionValorSeguroCodigo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SucursalBancaria_InstitucionValorSeguro");

            entity.HasOne(d => d.Comuna).WithMany(p => p.SucursalBancaria)
                .HasForeignKey(d => new { d.RegionCodigo, d.CiudadCodigo, d.ComunaCodigo })
                .HasConstraintName("FK_SucursalBancaria_Comuna");
        });

        modelBuilder.Entity<TipoAdministracion>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoAdministracion");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoAlmacen>(entity =>
        {
            entity.ToTable("TipoAlmacen", "Inventario");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCuentaEstadoResultado>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoCuentaEstadoResultado", "Contabilidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCuentum>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoCuenta", "Contabilidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCuentum1>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoCuenta");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoDocumento", "Contabilidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Sigla)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDocumentoFactura>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoDocumentoFactura", "Adquisiciones");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDocumentoRecepcion>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoDocumentoRecepcion", "Adquisiciones");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoEstablecimientoSalud>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoEstablecimientoSalud");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoGastoOperacional>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoGastoOperacional", "Contabilidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoIngresoOperacional>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoIngresoOperacional", "Contabilidad");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoInstitucionValorSeguro>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoInstitucionValorSeguro");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.CodigoDipres)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CodigoDIPRES");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoLocacion>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.Id });

            entity.ToTable("TipoLocacion", "Inventario");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<TipoUnidad>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TipoUnidad", "Inventario");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Signo)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Titulo>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("Titulo");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.CodigoDipres)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CodigoDIPRES");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaId, e.Id });

            entity.ToTable("Unidad");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.HasOne(d => d.Administrador).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.AdministradorId)
                .HasConstraintName("FK_Unidad_Administrador");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Unidad_Empresa");
        });

        modelBuilder.Entity<UnidadFuncional>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("UnidadFuncional");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.CodigoDipres).HasColumnName("CodigoDIPRES");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
