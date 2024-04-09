namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class ActividadEconomicaDTO 
    {
        public int ActividadEconomicaPrincipalCodigo
        {
            get;
            set;
        }
        public int SectorActividadEconomicaCodigo
        {
            get;
            set;
        }
        public int Codigo
        {
            get;
            set;
        }
        public string Descripcion
        {
            get;
            set;
        } = null!;
    }
}
