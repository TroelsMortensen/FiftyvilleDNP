using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("flights")]
    public class Flight
    {
        [Key, Column("id")]public int Id { get; set; }
        [Column("origin_airport_id")]public int OriginAirportId { get; set; }
        [Column("destination_airport_id")]public int DestinationAirportId { get; set; }
        [Column("year")] public int Year { get; set; }
        [Column("month")] public int Month { get; set; }
        [Column("day")] public int Day { get; set; }
        [Column("hour")] public int Hour { get; set; }
        [Column("minute")] public int Minute { get; set; }
    }
}