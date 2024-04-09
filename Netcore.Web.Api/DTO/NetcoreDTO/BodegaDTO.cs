namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class BodegaDTO
    {
        public int EmpresaId
        {
            get;
            set;
        }
        public int CentroCostoId
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        } = null!;
        public string Sigla
        {
            get;
            set;
        } = null!;
        public string Descripcion
        {
            get;
            set;
        } = null!;

    }
}
