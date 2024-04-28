namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class AlmacenDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid CentroCostoId { get; set; }
        public Guid BodegaId { get; set; }
        public Guid? Id { get; set; }
        public Guid TipoAlmacenId { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public TipoAlmacen_ALMACENDTO TipoAlmacen { get; set; }
        public Locacions_ALMACENDTO[] Locacions{ get; set; }
    }

    public class TipoAlmacen_ALMACENDTO
    {
        public Guid? Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
    }
        public class Locacions_ALMACENDTO
    {
        public Guid? Id { get; set; }
        public string? Direccion { get; set; }
        public string? Descripcion { get; set; }
    }

}
