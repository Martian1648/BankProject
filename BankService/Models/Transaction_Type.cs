using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BankService.Models
{
    public partial class Transaction_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction_Type()
        {
            //this.Transaction = new HashSet<Transaction>();
        }

        public Transaction_Type(BankService.Transaction_Type transaction_type)
        {
            this.Number = transaction_type.Number;
            this.Name = transaction_type.Name;
            //this.Transaction = new HashSet<Transaction>(Conversion_Functions.CreateTransaction_Objs(transaction_type.Transaction));
        }

        public int Number { get; set; }
        public string Name { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Transaction> Transaction { get; set; }
        public BankService.Transaction_Type Make_Transaction_Type()
        {
            return new BankService.Transaction_Type()
            {
                Number = this.Number,
                Name = this.Name,
                //Transaction = new HashSet<BankService.Transaction>(Conversion_Functions.CreateTransactions(this.Transaction)),
            };
        }

    }

}
