namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class ComunaDTO
    {
        public int RegionCodigo
        {
            get;
            set;
        }

        public int CiudadCodigo
        {
            get;
            set;
        }
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

        public int CodigoPostal
        {
            get;
            set;
        }

        public int CodigoLibroClaseElectronico
        {   
            get;
            set;
        }

        public int CodigoLRE
        {
            get;
            set;
        }
    }
}
