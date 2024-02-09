using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp3.Data.Classes
{
    [Table("vysledky")] // This specifies the table name in the database
    public class Vysledek1
    {
        [Key]
        public int IdVysledky { get; set; } // Primární klíč, automaticky generován
        public int? IdTurnaj { get; set; }
        public int? IB { get; set; }
        public int? IC { get; set; }
        public decimal? Vysledek { get; set; }
        public decimal? Sb { get; set; }




        //public int? Odehrane { get; set; }    hazi chybu musim to zakomentovat
        //public int? Procento { get; set; }     hazi chybu musim to zakomentovat
        //public int? IdHrac { get; set; }      hazi chybu musim to zakomentovat

        // Navigační vlastnosti pro cizí klíče, pokud jsou potřebné
        // public Turnaj Turnaj { get; set; }
        // public Hrac Hrac { get; set; }
    }
}
