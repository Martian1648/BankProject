using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;



namespace BankService.Models
{
    public partial class Bank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bank()
        {
 
        }

        public Bank(BankService.Bank bank)
        {
            this.Id = bank.Id;
            this.Name = bank.Name;
            this.Address = bank.Address;
            this.City = bank.City;
            this.State = bank.State;
            this.Zip = bank.Zip;
            this.Country = bank.Country;
            this.Url = bank.Url;
            this.Routing_Number = bank.Routing_Number;
      
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Url { get; set; }
        public string Routing_Number { get; set; }

   

        public BankService.Bank Make_Bank()
        {
            return new BankService.Bank()
            {
                Id = this.Id,
                Name = this.Name,
                Address = this.Address,
                City = this.City,
                State = this.State,
                Zip = this.Zip,
                Country = this.Country,
                Url = this.Url,
                Routing_Number = this.Routing_Number,
             
            };
        }
    }
}
