using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("bank_accounts")]
    public class BankAccount
    {
        [Key, Column("account_number")] public int AccountNumber { get; set; }
        [Column("person_id")] public int PersonId { get; set; }
        [Column("creation_year")] public int CreationYear { get; set; }
    }
}