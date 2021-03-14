using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("people")]
    public class Person
    {
        [Key, Column("id")]public int Id { get; set; }
        [Column("name")]public string Name { get; set; }
        [Column("phone_number")] public string PhoneNumber { get; set; }
        [Column("passport_number")]public long? PassportNumber { get; set; }
        [Column("license_plate")]public string LicensePlate { get; set; }
    }
}