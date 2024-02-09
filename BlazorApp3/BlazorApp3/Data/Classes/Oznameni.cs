using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BlazorApp3.Data.Classes

{
    [Table("zpravy")] // This specifies the table name in the database
    public class Oznameni
    {
        [Key]
        public int IdZ { get; set; }
        public string? Zprava { get; set; }
        public string? Datum { get; set; }
        public string? Autor { get; set; }
    }

}


