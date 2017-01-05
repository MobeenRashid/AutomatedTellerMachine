using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Display(Name = "Account #")]
        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Account # must be between 6 and 10")]
        public string AccountNumber { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public ApplicationUser User { get; set; }

        [ForeignKey("User")]
        [Required]
        public string UserId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}