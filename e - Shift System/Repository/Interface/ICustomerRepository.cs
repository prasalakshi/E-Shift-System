using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Interface
{
    public interface ICustomerRepository
    {
        Customer GetCustomerByUsernameAndPassword(string username, string passwordHash);

        bool IsUsernameOrEmailExists(string username, string email);
        void AddCustomer(Customer customer);

        Customer GetCustomerById(int customerId);
        void UpdateCustomer(Customer customer);

        List<Customer> GetAllCustomers();
        
        void DeleteCustomer(int customerId);
        void UpdateCustomerContact(int customerId, string email, string contact);
    }
}
