using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiftyville.Model
{
    [Table("atm_transactions")]

    public class AtmTransaction
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("account_number")] public int AccountNumber { get; set; }
        [Column("year")]public int Year { get; set; }
        [Column("month")] public int Month { get; set; }
        [Column("day")] public int Day { get; set; }
        [Column("atm_location")] public string AtmLocation { get; set; }
        [Column("transaction_type")] public string TransactionType { get; set; }
        [Column("amount")] public int Amount { get; set; }
    }
}