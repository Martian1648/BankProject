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
            //this.Transaction = new HashSet<Transaction>();
            //this.Transaction1 = new HashSet<Transaction>();
        }

        public Account(BankService.Account account)
        {
            this.Id = account.Id;
            this.Customer_Id = account.Customer_Id;
            this.Bank_Id = account.Bank_Id;
            this.Balance = account.Balance;
            this.Interest_Rate = account.Interest_Rate;
            this.Type_Number = account.Type_Number;
            //this.Account_Type = account.Account_Type;
            //this.Bank = account.Bank;
            //this.Customer = account.Customer;
            //this.Transaction = new HashSet<Transaction>(Conversion_Functions.CreateTransaction_Objs(account.Transaction));
            //this.Transaction1 = new HashSet<Transaction>(Conversion_Functions.CreateTransaction_Objs(account.Transaction1));
        }

        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public int Bank_Id { get; set; }
        public decimal Balance { get; set; }
        public decimal Interest_Rate { get; set; }
        public int Type_Number { get; set; }
        //[IgnoreDataMember]

        //public virtual BankService.Account_Type Account_Type { get; set; }
        //[IgnoreDataMember]

        //public virtual Bank Bank { get; set; }
        //[IgnoreDataMember]

        //public virtual BankService.Customer Customer { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Transaction> Transaction { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Transaction> Transaction1 { get; set; }
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
                //Account_Type = this.Account_Type,
                //Bank = this.Bank,
                //Customer = this.Customer,
                //Transaction = new HashSet<BankService.Transaction>(Conversion_Functions.CreateTransactions(this.Transaction)),
                //Transaction1 = new HashSet<BankService.Transaction>(Conversion_Functions.CreateTransactions(this.Transaction1)),
            };
        }

    }
}
