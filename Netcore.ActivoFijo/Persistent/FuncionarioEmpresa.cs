using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class FuncionarioEmpresa : Netcore.ActivoFijo.Entity.FuncionarioEmpresa, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.FuncionarioEmpresa? funcionarioEmpresa = await context.FuncionarioEmpresas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.FuncionarioEmpresa>(x => x.EmpresaId == this.EmpresaId && x.FuncionarioId == this.FuncionarioId);

            if (funcionarioEmpresa == null)
            {
                funcionarioEmpresa = new FuncionarioEmpresa
                {
                    EmpresaId = this.EmpresaId,
                    FuncionarioId = this.FuncionarioId
                };

                await context.FuncionarioEmpresas.AddAsync(funcionarioEmpresa);
            }

            funcionarioEmpresa.GradoCertificadoProfesionalCodigo = this.GradoCertificadoProfesionalCodigo == default(Int32) ? null : this.GradoCertificadoProfesionalCodigo;
            funcionarioEmpresa.FormacionProfesional = this.FormacionProfesional;
            funcionarioEmpresa.Funcion = this.Funcion;
            funcionarioEmpresa.Puntaje = this.Puntaje == default(Decimal) ? null : this.Puntaje;
            funcionarioEmpresa.Activo = this.Activo;
            funcionarioEmpresa.Saldo = this.Saldo == default(Decimal) ? null : this.Saldo;
            funcionarioEmpresa.Titulo = this.Titulo;
            funcionarioEmpresa.InstitucionAcademica = this.InstitucionAcademica;
            funcionarioEmpresa.EstadoAcreditacionInstitucion = this.EstadoAcreditacionInstitucion;
            funcionarioEmpresa.MetodoVerificacionEducacion = this.MetodoVerificacionEducacion;
            funcionarioEmpresa.FechaGraduacion = this.FechaGraduacion == default(DateTime) ? null : this.FechaGraduacion;
            funcionarioEmpresa.PagarAlumnosPrioritarios = this.PagarAlumnosPrioritarios;
            funcionarioEmpresa.ReliquidacionId = this.ReliquidacionId == default(Guid) ? null : this.ReliquidacionId;
            funcionarioEmpresa.NumeroBienioReliquidado = this.NumeroBienioReliquidado == default(Int32) ? null : this.NumeroBienioReliquidado;
            funcionarioEmpresa.BrpTitulo = this.BrpTitulo;
            funcionarioEmpresa.BrpMencion = this.BrpMencion;
            funcionarioEmpresa.TituloCodigo = this.TituloCodigo == default(Int32) ? null : this.TituloCodigo;
            funcionarioEmpresa.UnidadFuncionalCodigo = this.UnidadFuncionalCodigo == default(Int32) ? null : this.UnidadFuncionalCodigo;
            funcionarioEmpresa.PostTituloCodigo = this.PostTituloCodigo == default(Int32) ? null : this.PostTituloCodigo;
            funcionarioEmpresa.EspecialidadCodigo = this.EspecialidadCodigo == default(Int32) ? null : this.EspecialidadCodigo;
            funcionarioEmpresa.InicioNombramientoContrata = this.InicioNombramientoContrata == default(DateTime) ? null : this.InicioNombramientoContrata;
            funcionarioEmpresa.InicioNombramientoTitular = this.InicioNombramientoTitular == default(DateTime) ? null : this.InicioNombramientoTitular;
            funcionarioEmpresa.TerminoNombramiento = this.TerminoNombramiento == default(DateTime) ? null : this.TerminoNombramiento;
            funcionarioEmpresa.IngresoServicio = this.IngresoServicio == default(DateTime) ? null : this.IngresoServicio;
            funcionarioEmpresa.FechaInicioCalidadJuridicaContrata = this.FechaInicioCalidadJuridicaContrata == default(DateTime) ? null : this.FechaInicioCalidadJuridicaContrata;
            funcionarioEmpresa.FechaInicioCalidadJuridicaPlanta = this.FechaInicioCalidadJuridicaPlanta == default(DateTime) ? null : this.FechaInicioCalidadJuridicaPlanta;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.FuncionarioEmpresa? funcionarioEmpresa = await context.FuncionarioEmpresas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.FuncionarioEmpresa>(x => x.EmpresaId == this.EmpresaId && x.FuncionarioId == this.FuncionarioId);

            if (funcionarioEmpresa != null)
            {
                context.FuncionarioEmpresas.Remove(funcionarioEmpresa);
            }
        }
    }
}