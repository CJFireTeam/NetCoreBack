﻿using Mapster;
using Netcore.Abstraction.Helper;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;
using Netcore.Abstraction.Helper;
namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class PersonaController : BaseController, IPersona
    {
        private Context _context;

        public PersonaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            PersonaModel Model = new PersonaModel();

            Model.Success = true;

            try
            {

                List<Netcore.ActivoFijo.Business.Persona> business = await Netcore.ActivoFijo.Business.Persona.GetAllAsync(this._context);

                List<PersonaDTO> listDTO = business.Select(t => t.Adapt<PersonaDTO>()).ToList();

                Model.Code = (int)StatusCodes.Status200OK;
                Model.DataList = listDTO;

                return Results.Ok(Model);
            }
            catch (Exception ex)
            {
                Model.Success = false;
                Model.Status = "ERROR";
                Model.SubStatus = "ERROR";
                Model.Message = ex.Message;
                Model.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(Model);
            }
        }

        public async Task<IResult> Post(PersonaDTO PersonaDTO)
        {
            PersonaModel Model = new PersonaModel();

            Model.Success = true;

            try
            {
                if
                (
                    string.IsNullOrEmpty(PersonaDTO.ApellidoPaterno) || string.IsNullOrWhiteSpace(PersonaDTO.ApellidoPaterno) ||
                    string.IsNullOrEmpty(PersonaDTO.Nombres) || string.IsNullOrWhiteSpace(PersonaDTO.Nombres)
                )
                {
                    throw new Exception("Campos requeridos");
                }


                if (!Helper.ValidateRut(PersonaDTO.RunCuerpo, PersonaDTO.RunDigito.ToString())) throw new Exception("Rut erroneo");
                Netcore.ActivoFijo.Business.Sexo sexo = await Netcore.ActivoFijo.Business.Sexo.GetAsync(this._context, PersonaDTO.SexoCodigo);
                if (sexo == null) throw new Exception("Campo requerido");


                Netcore.ActivoFijo.Business.Persona business = await Netcore.ActivoFijo.Business.Persona.Insert(
                    this._context, 
                    PersonaDTO.RunCuerpo,
                    PersonaDTO.RunDigito.ToString(),
                    PersonaDTO.Nombres, 
                    PersonaDTO.ApellidoPaterno,
                    PersonaDTO.SexoCodigo);

                PersonaDTO dto = business.Adapt<PersonaDTO>();

                Model.Code = (int)StatusCodes.Status200OK;
                Model.Data = dto;
                Model.Message = "Agregado correctamente";
                return Results.Ok(Model);
            }
            catch (Exception ex)
            {
                Model.Success = false;
                Model.Status = "ERROR";
                Model.SubStatus = "ERROR";
                Model.Message = ex.Message;
                Model.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(Model);
            }
        }
        // public async Task<IResult> Put(PersonaDTO PersonaDTO)
        // {
        //     PersonaModel Model = new PersonaModel();

        //     Model.Success = true;

        //     try
        //     {
        //         if (PersonaDTO.Id == null) throw new("Id no encontrado");
        //         Netcore.ActivoFijo.Business.Persona find = await Netcore.ActivoFijo.Business.Persona.FindOne(this._context, PersonaDTO.Id);                
        //         Netcore.ActivoFijo.Business.Persona business = await Netcore.ActivoFijo.Business.Persona.Update(this._context,PersonaDTO.Id, PersonaDTO.Codigo, PersonaDTO.Nombre);
        //         PersonaDTO dto = business.Adapt<PersonaDTO>();

        //         Model.Code = (int)StatusCodes.Status200OK;
        //         Model.Data = dto;
        //         Model.Message = "Modificado correctamente";
        //         return Results.Ok(Model);
        //     }
        //     catch (Exception ex)
        //     {
        //         Model.Success = false;
        //         Model.Status = "ERROR";
        //         Model.SubStatus = "ERROR";
        //         Model.Message = ex.Message;
        //         Model.Code = (int)StatusCodes.Status500InternalServerError;

        //         return Results.BadRequest(Model);
        //     }
        // }
    }
}