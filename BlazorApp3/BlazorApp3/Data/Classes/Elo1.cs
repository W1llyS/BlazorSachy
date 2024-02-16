using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp3.Data.Classes
{
    [Table("Elo")] // This specifies the table name in the database
    public class Elo1
    {
        public int? IdPlayer { get; set; }
        public string? Datum { get; set; }
        public int? Hodnota { get; set; }

        [Key]
        public int Id { get; set; } // Primární klíč, automaticky generován
        public char? Viditelnost { get; set; }
    }
}
