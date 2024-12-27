using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankService.Models
{
    public partial class Account_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account_Type()
        {
        }

        public Account_Type(BankService.Account_Type account_type)
        {
            this.Number = account_type.Number;
            this.Name = account_type.Name;
        }

        public int Number { get; set; }
        public string Name { get; set; }

      
        public BankService.Account_Type Make_Account_Type()
        {
            return new BankService.Account_Type()
            {
                Number = this.Number,
                Name = this.Name,
            };
        }

    }
}
