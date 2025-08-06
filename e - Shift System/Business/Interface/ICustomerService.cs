using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface ICustomerService
    {
        Customer AuthenticateCustomer(string username, string passwordHash);

        bool RegisterCustomer(Customer customer, string confirmPassword, out string errorMessage);

        Customer GetCustomerById(int customerId);
        void UpdateCustomerProfile(Customer customer, out string errorMessage);
        Customer? GetCustomerById(object customerID);     
        
        List<Customer> GetAllCustomers();
        void DeleteCustomer(int CustomerId, out string errorMessage);

        void EditCustomer(int CustomerId, string email, string contact, out string errorMessage);
                
        public bool ValidateCustomerProfile(string email, string contact, out string errorMessage);

        public bool ValidateContactNumber(string contact);

        public bool ValidateEmail(string email);


    }
}
