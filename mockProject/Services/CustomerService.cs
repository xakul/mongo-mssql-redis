using Microsoft.EntityFrameworkCore;
using mockProject.Interfaces;
using mockProject.Persistences.Mssql;

namespace mockProject.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly BaseContext _baseContext;
        public CustomerService(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            var customerList = await _baseContext.Customers.ToListAsync();

            return customerList;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            await _baseContext.Customers.AddAsync(customer);

            return customer;
        }
    }
}
