using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("airports")]
    public class Airport
    {
        [Key, Column("id")]
        public int Id { get; set; }
    [Column("abbreviation")]
        public string Abbreviation { get; set; }
        [Column("full_name")]
        public string FullName { get; set; }
        [Column("city")]
        public string City { get; set; }
        
    }
}