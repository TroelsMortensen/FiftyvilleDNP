using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("interviews")]
    public class Interview
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("name")] public string Name { get; set; }
        [Column("year")] public int Year { get; set; }
        [Column("month")] public int Month { get; set; }
        [Column("day")] public int Day { get; set; }
        [Column("transcript")] public string Transcript { get; set; }
    }
}