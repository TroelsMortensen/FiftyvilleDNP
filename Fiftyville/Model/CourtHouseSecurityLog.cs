using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("courthouse_security_logs")]
    public class CourtHouseSecurityLog
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("year")] public int Year { get; set; }
        [Column("month")] public int Month { get; set; }
        [Column("day")] public int Day { get; set; }
        [Column("hour")] public int Hour { get; set; }
        [Column("minute")] public int Minute { get; set; }
        [Column("activity")] public string Activity { get; set; }
        [Column("license_plate")] public string LicensePlate { get; set; }
    }
}