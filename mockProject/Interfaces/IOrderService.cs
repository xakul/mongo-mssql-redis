using mockProject.Persistences.Mssql;

namespace mockProject.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllOrders();

        Task<Order> GetOrderById(int id);
    }
}
