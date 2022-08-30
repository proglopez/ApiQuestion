using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiQuestion.Entities
{
    [Table("NombreTabla", Schema = "EsquemaTabla")]
    public class ListaModel
    {
        [Key]
        public int ListaID { get; set; }
        public string? ListaElementsCode {  get; set; }
        public string? ListaName { get; set; }
        public string? ListaCode { get; set; }
        public string? ListaType { get; set; }
    }
}
