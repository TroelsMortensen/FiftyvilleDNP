using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("crime_scene_reports")]
    public class CrimeSceneReport
    {
        [Key, Column("id")] public int Id { get; set; }

        [Column("year")] public int Year { get; set; }
        [Column("month")] public int Month { get; set; }
        [Column("day")] public int Day { get; set; }
        [Column("street")] public string Street { get; set; }
        [Column("description")] public string Description { get; set; }
    }
}