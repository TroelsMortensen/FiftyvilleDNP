using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("phone_calls")]
    public class PhoneCall
    {
        [Key, Column("id")]public int Id { get; set; }
        [Column("caller")]public string Caller { get; set; }
        [Column("receiver")]public string Receiver { get; set; }
        [Column("year")]public int Year { get; set; }
        [Column("month")] public int Month { get; set; }
        [Column("day")] public int Day { get; set; }
        [Column("duration")]public int Duration { get; set; }
    }
}