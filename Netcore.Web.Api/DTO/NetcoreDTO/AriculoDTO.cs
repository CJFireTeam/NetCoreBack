namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class ArticuloDTO
    {
        public Guid EmpresaId { get; set; }
        public int AnoNumero { get; set; }
        public Guid SubFamiliaId { get; set; }
        public Guid Id { get; set; }
        public int TipoUnidadCodigo { get; set; }
        public string? Codigo { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public Boolean Eliminado { get; set; }
        public Articulo_valors[] ArticuloValors {get;set;}

    }
        public class Articulo_valors {
            public float Valor {get;set;}

        }
}