using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace BankService.Models
{
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
      
        }

        public Account(BankService.Account account)
        {
            this.Id = account.Id;
            this.Customer_Id = account.Customer_Id;
            this.Bank_Id = account.Bank_Id;
            this.Balance = account.Balance;
            this.Interest_Rate = account.Interest_Rate;
            this.Type_Number = account.Type_Number;
        
        }

        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public int Bank_Id { get; set; }
        public decimal Balance { get; set; }
        public decimal Interest_Rate { get; set; }
        public int Type_Number { get; set; }
      
        public BankService.Account Make_Account()
        {
            return new BankService.Account()
            {
                Id = this.Id,
                Customer_Id = this.Customer_Id,
                Bank_Id = this.Bank_Id,
                Balance = this.Balance,
                Interest_Rate = this.Interest_Rate,
                Type_Number = this.Type_Number,
              
            };
        }

    }
}
