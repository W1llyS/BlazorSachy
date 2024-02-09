using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp3.Data.Classes
{
    [Table("turnaje")] // This specifies the table name in the database
    public class Turnaj1
    {
        [Key]
        public int IDturnaj { get; set; }
        public string? Nazev { get; set; }
        public DateTime? DatumZalozeni { get; set; }
        public int? DelkaPartie { get; set; }
        public string? Poradatel { get; set; }
        public string? Rozhodci { get; set; }
        public string? Reditel { get; set; }
        public string? Misto { get; set; }
        public int? DelkaTurnaje { get; set; }
        public DateTime? Zahajeni { get; set; }
        public DateTime? Ukonceni { get; set; }
        public int? ZpusobLosu { get; set; }
        public int? Stav { get; set; }
        public int? PocetHracu { get; set; }
        public int? PocetKol { get; set; }
        public int? OpakovaniKol { get; set; }
        public int? PocetPartii { get; set; }
        public int? PocetZapasuvKole { get; set; }

        // Navigační vlastnosti pro cizí klíče, pokud je potřebujete
        // public DelkaPartie DelkaPartie { get; set; }
        // public DelkaTurnaje DelkaTurnaje { get; set; }
        // public Los Los { get; set; }
    }
}
