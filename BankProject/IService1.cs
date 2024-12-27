//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.ServiceModel;
//using System.Text;

//namespace BankProject
//{
//    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
//    [ServiceContract]
//    public interface IService1
//    {
//        [OperationContract]
//        IEnumerable<Bank_Obj> GetBanks();
//        [OperationContract]
//        IEnumerable<Account_Obj> GetAccounts();
//        [OperationContract]
//        IEnumerable<Account_Type_Obj> GetAccountTypes();

//        [OperationContract]
//        IEnumerable<Customer_Obj> GetCustomers();

//        [OperationContract]
//        IEnumerable<Employee_Obj> GetEmployees();

//        [OperationContract]
//        IEnumerable<Transaction_Obj> GetTransactions();

//        [OperationContract]
//        IEnumerable<Transaction_Type_Obj> GetTransactionTypes();
//        [OperationContract]
//        Bank_Obj GetData(int value);

//        [OperationContract]
//        CompositeType GetDataUsingDataContract(CompositeType composite);

//        // TODO: Add your service operations here

//        [OperationContract]
//        void Add_Bank(Bank_Obj bank);

//        [OperationContract]
//        void Remove_Bank(int id);

//        [OperationContract]
//        void Update_Bank(Bank_Obj bank);

//        [OperationContract]
//        void Add_Account(Account_Obj account);

//        [OperationContract]
//        void Remove_Account(int id);

//        [OperationContract]
//        void Update_Account(Account_Obj account);

//        [OperationContract]
//        void Add_Account_Type(Account_Type_Obj accountType);

//        [OperationContract]
//        void Remove_Account_Type(int number);

//        [OperationContract]
//        void Update_Account_Type(Account_Type_Obj accountType);

//        [OperationContract]
//        void Add_Customer(Customer_Obj customer);

//        [OperationContract]
//        void Remove_Customer(int id);

//        [OperationContract]
//        void Update_Customer(Customer_Obj customer);

//        [OperationContract]
//        void Add_Employee(Employee_Obj employee);

//        [OperationContract]
//        void Remove_Employee(int id);

//        [OperationContract]
//        void Update_Employee(Employee_Obj employee);

//        [OperationContract]
//        void Add_Transaction(Transaction_Obj transaction);

//        [OperationContract]
//        void Remove_Transaction(int id);

//        [OperationContract]
//        void Update_Transaction(Transaction_Obj transaction);

//        [OperationContract]
//        void Add_Transaction_Type(Transaction_Type_Obj transactionType);

//        [OperationContract]
//        void Remove_Transaction_Type(int number);

//        [OperationContract]
//        void Update_Transaction_Type(Transaction_Type_Obj transactionType);


//    }

//    // Use a data contract as illustrated in the sample below to add composite types to service operations.
//    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "BankProject.ContractType".
//    [DataContract]
//    public class CompositeType
//    {
//        bool boolValue = true;
//        string stringValue = "Hello ";

//        [DataMember]
//        public bool BoolValue
//        {
//            get { return boolValue; }
//            set { boolValue = value; }
//        }

//        [DataMember]
//        public string StringValue
//        {
//            get { return stringValue; }
//            set { stringValue = value; }
//        }
//    }
//}
