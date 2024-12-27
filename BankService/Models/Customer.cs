using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace BankService.Models
{
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            //this.Account = new HashSet<Account>();
            //this.Transaction = new HashSet<Transaction>();
        }

        public Customer(BankService.Customer customer)
        {
            this.Id = customer.Id;
            this.Bank_Id = customer.Bank_Id;
            this.First_Name = customer.First_Name;
            this.Middle_Initial = customer.Middle_Initial;
            this.Last_Name = customer.Last_Name;
            this.Address = customer.Address;
            this.City = customer.City;
            this.State = customer.State;
            this.Zip = customer.Zip;
            this.Country = customer.Country;
            this.Email = customer.Email;
            this.Phone = customer.Phone;
            this.Password = customer.Password;
            //this.Account = new HashSet<Account>(Conversion_Functions.CreateAccount_Objs(customer.Account));
            //this.Transaction = new HashSet<Transaction>(Conversion_Functions.CreateTransaction_Objs(customer.Transaction));
        }

        public int Id { get; set; }
        public int Bank_Id { get; set; }
        public string First_Name { get; set; }
        public string Middle_Initial { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Account> Account { get; set; }
        //[IgnoreDataMember]

        //public virtual Bank Bank { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Transaction> Transaction { get; set; }
        public BankService.Customer Make_Customer()
        {
            return new BankService.Customer()
            {
                Id = this.Id,
                Bank_Id = this.Bank_Id,
                First_Name = this.First_Name,
                Middle_Initial = this.Middle_Initial,
                Last_Name = this.Last_Name,
                Address = this.Address,
                City = this.City,
                State = this.State,
                Zip = this.Zip,
                Country = this.Country,
                Email = this.Email,
                Phone = this.Phone,
                Password = this.Password,
                //Account = new HashSet<BankService.Account>(Conversion_Functions.CreateAccounts((this.Account))),
                //Transaction = new HashSet<BankService.Transaction>(Conversion_Functions.CreateTransactions(this.Transaction)),
            };
        }

    }

}
