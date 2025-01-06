using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankService.Models
{
    public struct Temp
    {
        public decimal Amount { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public struct Report_Bank_Transaction
    {
        public decimal Amount { get; set; }
        public Nullable<int> From_Account_Id { get; set; }
        public Nullable<int> To_Account_Id { get; set; }
        public int Customer_Id { get; set; }        
    }
}