using Mapster;
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



        public async Task<IResult> Get(int page, int perPage)
        {
            PersonaModel Model = new PersonaModel();

            Model.Success = true;

            try
            {

                List<Netcore.ActivoFijo.Business.Persona> business = await Netcore.ActivoFijo.Business.Persona.GetAllAsyncPaginated(this._context, page, perPage);
                int count = Netcore.ActivoFijo.Business.Persona.GetCount(this._context);
                List<PersonaDTO> listDTO = business.Select(t => t.Adapt<PersonaDTO>()).ToList();
                Model.Pages = (int)Math.Ceiling((double)count / perPage);
                Model.Total = count;
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

        public async Task<IResult> huella(IFormFile input, string id)
        {
            PersonaModel Model = new PersonaModel();
            Model.Success = true;

            try
            {
                if (!Guid.TryParse(id, out Guid guid)) throw new Exception("Usuario no valido");
                byte[] imagenBytes;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    await input.CopyToAsync(memoryStream);
                    imagenBytes = memoryStream.ToArray();
                }

                if (!Netcore.ActivoFijo.Business.Persona.ExistById(this._context, guid)) throw new Exception("El usuario no existe");

                Netcore.ActivoFijo.Business.Persona business = await Netcore.ActivoFijo.Business.Persona.setHuella(this._context, imagenBytes, guid);

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
                if (Netcore.ActivoFijo.Business.Persona.ExistByRut(this._context, PersonaDTO.RunCuerpo, PersonaDTO.RunDigito.ToString())) throw new Exception("El usuario ya se encuentra registrado");

                Netcore.ActivoFijo.Business.Persona business = await Netcore.ActivoFijo.Business.Persona.Insert(
                    this._context,
                    PersonaDTO.RunCuerpo,
                    PersonaDTO.RunDigito.ToString(),
                    PersonaDTO.Nombres,
                    PersonaDTO.ApellidoPaterno,
                    PersonaDTO.SexoCodigo,
                    PersonaDTO.ApellidoMaterno,
                    PersonaDTO.Email,
                    PersonaDTO.NacionalidadCodigo,
                    PersonaDTO.EstadoCivilCodigo,
                    PersonaDTO.NivelEducacionalCodigo,
                    PersonaDTO.RegionCodigo,
                    PersonaDTO.CiudadCodigo,
                    PersonaDTO.ComunaCodigo,
                    PersonaDTO.RegionNacimientoCodigo,
                    PersonaDTO.CiudadNacimientoCodigo,
                    PersonaDTO.ComunaNacimientoCodigo,
                    PersonaDTO.VillaPoblacion,
                    PersonaDTO.Direccion,
                    PersonaDTO.Telefono,
                    PersonaDTO.Celular,
                    PersonaDTO.Observaciones,
                    PersonaDTO.Ocupacion,
                    PersonaDTO.TelefonoLaboral,
                    PersonaDTO.DireccionLaboral,
                    PersonaDTO.AreaGeograficaCodigo,
                    PersonaDTO.NroDepartamento,
                    PersonaDTO.FechaNacimiento
                    );

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
        public async Task<IResult> Put(PersonaDTO PersonaDTO)
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

                if (!Guid.TryParse(PersonaDTO.Id, out Guid guid)) throw new Exception("Usuario no valido");

                if (!Helper.ValidateRut(PersonaDTO.RunCuerpo, PersonaDTO.RunDigito.ToString())) throw new Exception("Rut erroneo");
                Netcore.ActivoFijo.Business.Sexo sexo = await Netcore.ActivoFijo.Business.Sexo.GetAsync(this._context, PersonaDTO.SexoCodigo);
                if (sexo == null) throw new Exception("Campo requerido");
                if (!Netcore.ActivoFijo.Business.Persona.ExistByRut(this._context, PersonaDTO.RunCuerpo, PersonaDTO.RunDigito.ToString())) throw new Exception("El usuario no se encuentra registrado");

                Netcore.ActivoFijo.Business.Persona business = await Netcore.ActivoFijo.Business.Persona.Update(
                    this._context,
                    guid,
                    PersonaDTO.RunCuerpo,
                    PersonaDTO.RunDigito.ToString(),
                    PersonaDTO.Nombres,
                    PersonaDTO.ApellidoPaterno,
                    PersonaDTO.SexoCodigo,
                    PersonaDTO.ApellidoMaterno,
                    PersonaDTO.Email,
                    PersonaDTO.NacionalidadCodigo,
                    PersonaDTO.EstadoCivilCodigo,
                    PersonaDTO.NivelEducacionalCodigo,
                    PersonaDTO.RegionCodigo,
                    PersonaDTO.CiudadCodigo,
                    PersonaDTO.ComunaCodigo,
                    PersonaDTO.RegionNacimientoCodigo,
                    PersonaDTO.CiudadNacimientoCodigo,
                    PersonaDTO.ComunaNacimientoCodigo,
                    PersonaDTO.VillaPoblacion,
                    PersonaDTO.Direccion,
                    PersonaDTO.Telefono,
                    PersonaDTO.Celular,
                    PersonaDTO.Observaciones,
                    PersonaDTO.Ocupacion,
                    PersonaDTO.TelefonoLaboral,
                    PersonaDTO.DireccionLaboral,
                    PersonaDTO.AreaGeograficaCodigo,
                    PersonaDTO.NroDepartamento,
                    PersonaDTO.FechaNacimiento
                    );

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

    }
}