using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomatedTellerMachine.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [ForeignKey("CheckingAccount")]
        public int CheckingAccountId { get; set; }
        public virtual CheckingAccount CheckingAccount { get; set; }
    }
}