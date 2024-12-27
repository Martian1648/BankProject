using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BankService.Models
{
    public partial class Transaction
    {
        public Transaction() { }
        public Transaction(BankService.Transaction transaction) 
        {
            this.Id = transaction.Id;
            this.Customer_Id = transaction.Customer_Id;
            this.Type_Number = transaction.Type_Number;
            this.From_Account_Id = transaction.From_Account_Id;
            this.To_Account_Id = transaction.To_Account_Id;
            //this.Account = transaction.Account;
            //this.Account1 = transaction.Account1;
            //this.Customer = transaction.Customer;
            //this.Transaction_Type = transaction.Transaction_Type;
        }
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public int Type_Number { get; set; }
        public int From_Account_Id { get; set; }
        public Nullable<int> To_Account_Id { get; set; }
        //[IgnoreDataMember]

        //public virtual Account Account { get; set; }
        //[IgnoreDataMember]

        //public virtual Account Account1 { get; set; }
        //[IgnoreDataMember]

        //public virtual Customer Customer { get; set; }
        //[IgnoreDataMember]

        //public virtual Transaction_Type Transaction_Type { get; set; }
        public BankService.Transaction Make_Transaction()
        {
            return new BankService.Transaction()
            {
                Id = this.Id,
                Customer_Id = this.Customer_Id,
                Type_Number = this.Type_Number,
                From_Account_Id = this.From_Account_Id,
                To_Account_Id = this.To_Account_Id,
                //Account = this.Account,
                //Account1 = this.Account1,
                //Customer = this.Customer,
                //Transaction_Type = this.Transaction_Type,
            };
        }

    }
}
