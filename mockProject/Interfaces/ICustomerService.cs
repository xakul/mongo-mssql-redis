using mockProject.Persistences.Mssql;

namespace mockProject.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();

        Task<Customer> CreateCustomer(Customer customer);
    }
}
