using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;


namespace BankService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file toGetAllher.
    [ServiceContract]
    public interface IDataService
    {
        //basic CRUD stuff
        #region
        [OperationContract]
        IEnumerable<Models.Bank> GetAllBanks();
        [OperationContract]
        Models.Bank GetBank(int id);

        [OperationContract]
        Models.Account GetAccount(int id);

        [OperationContract]
        Models.Account_Type GetAccountType(int number);

        [OperationContract]
        Models.Customer GetCustomer(int id);

        [OperationContract]
        Models.Employee GetEmployee(int id);

        [OperationContract]
        Models.Transaction GetTransaction(int id);

        [OperationContract]
        Models.Transaction_Type GetTransactionType(int number);

        [OperationContract]
        IEnumerable<Models.Account> GetAllAccounts();
        [OperationContract]
        IEnumerable<Models.Account_Type> GetAllAccountTypes();

        [OperationContract]
        IEnumerable<Models.Customer> GetAllCustomers();

        [OperationContract]
        IEnumerable<Models.Employee> GetAllEmployees();

        [OperationContract]
        IEnumerable<Models.Transaction> GetAllTransactions();

        [OperationContract]
        IEnumerable<Models.Transaction_Type> GetAllTransactionTypes();
        [OperationContract]
        void Add_Bank(Models.Bank bank);

        [OperationContract]
        void Remove_Bank(int id);

        [OperationContract]
        void Update_Bank(Models.Bank bank);

        [OperationContract]
        void Add_Account(Models.Account account);

        [OperationContract]
        void Remove_Account(int id);

        [OperationContract]
        void Update_Account(Models.Account account);

        [OperationContract]
        void Add_Account_Type(Models.Account_Type accountType);

        [OperationContract]
        void Remove_Account_Type(int number);

        [OperationContract]
        void Update_Account_Type(Models.Account_Type accountType);

        [OperationContract]
        void Add_Customer(Models.Customer customer);

        [OperationContract]
        void Remove_Customer(int id);

        [OperationContract]
        void Update_Customer(Models.Customer customer);

        [OperationContract]
        void Add_Employee(Models.Employee employee);

        [OperationContract]
        void Remove_Employee(int id);

        [OperationContract]
        void Update_Employee(Models.Employee employee);

        [OperationContract]
        void Add_Transaction(Models.Transaction transaction);

        [OperationContract]
        void Remove_Transaction(int id);

        [OperationContract]
        void Update_Transaction(Models.Transaction transaction);

        [OperationContract]
        void Add_Transaction_Type(Models.Transaction_Type transactionType);

        [OperationContract]
        void Remove_Transaction_Type(int number);

        [OperationContract]
        void Update_Transaction_Type(Models.Transaction_Type transactionType);
        #endregion

        //retreive all customers in given bank
        [OperationContract]
        IEnumerable<Models.Customer> GetCustomersofBank(int id);

        //retrieve all employees in given bank
        [OperationContract]
        IEnumerable<Models.Employee> GetEmployeesofBank(int id);

        //retrieve all accounts of a given customer
        [OperationContract]
        IEnumerable<Models.Account> GetAccountsofCustomer(int id);

        //retrieve all transactions of a given customer
        [OperationContract]
        IEnumerable<Models.Transaction> GetTransactionsofCustomer(int id);

        //make deposit
        [OperationContract]
        void MakeTransaction(Models.Transaction transaction);


        [OperationContract]
        void Testing_Commands();
    }



}
