using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp3.Data.Classes
{
    [Table("ProKlikaciTabulku")] // This specifies the table name in the database
    public class ProKlikaciTabulka1
    {
        [Key]
        public int? IdKt { get; set; } // Primární klíč, automaticky generován
        public string? Hrac { get; set; }
        public string? Klub { get; set; }
        public decimal? Body { get; set; }
        public decimal? Sb { get; set; }
        public int? Odehrane { get; set; }
        public int? Procento { get; set; }
        public int? IdTurnaj { get; set; }
        public int? IdHrac { get; set; }
    }
}
