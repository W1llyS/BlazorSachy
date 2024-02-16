using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp3.Data.Classes
{
    [Table("Players")] // This specifies the table name in the database
    public class Player1
    {


        [Key]
        public int? IdPlayer { get; set; }
        public string? Prijmeni { get; set; }
        public string? Klub { get; set; }
        public DateTime? Narozen { get; set; }
        public int? Elo { get; set; }
        public string? Kategorie { get; set; }
        public string? Rezerva { get; set; }
        public string? Krestni { get; set; }
        public int? PAktivni { get; set; }
    }
}
