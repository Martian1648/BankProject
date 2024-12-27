using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace BankService.Models
{
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {

        }
        public Employee(BankService.Employee employee) 
        {
            this.Id = employee.Id;
            this.Bank_Id = employee.Bank_Id;
            this.First_Name = employee.First_Name;
            this.Middle_Initial = employee.Middle_Initial;
            this.Last_Name = employee.Last_Name;
            this.Address = employee.Address;
            this.City = employee.City;
            this.State = employee.State;
            this.Zip = employee.Zip;
            this.Country = employee.Country;
            this.Email = employee.Email;
            this.Phone = employee.Phone;
            this.Job = employee.Job;
            this.Password = employee.Password;
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
        public string Job { get; set; }
        public string Password { get; set; }
        //[IgnoreDataMember]

        //public virtual Bank Bank { get; set; }
        public BankService.Employee Make_Employee()
        {
            return new BankService.Employee()
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
                Job = this.Job,
                Password = this.Password,
            };
        }

    }
}
