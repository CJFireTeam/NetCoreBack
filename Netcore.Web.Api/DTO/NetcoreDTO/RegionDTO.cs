namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class RegionDTO
    {

        public int Codigo
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        } = null!;

        public string NombreOficial
        {
            get;
            set;
        } = null!;

        public int CodigoLibroClaseElectronico
        {
            get;
            set;
        }
    }
}

