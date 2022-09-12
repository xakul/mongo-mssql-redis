using Microsoft.EntityFrameworkCore;
using mockProject.Interfaces;
using mockProject.Persistences.Mssql;

namespace mockProject.Services
{
    public class OrderService : IOrderService
    {
        private readonly BaseContext _baseContext;
        public OrderService(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public async Task<List<Order>> GetAllOrders()
        {
            var orderList = await _baseContext.Orders.Include(a => a.Customer).ToListAsync();

            return orderList;
        }

        public async Task<Order> GetOrderById(int id)
        {
            var order = await this._baseContext.Orders.FirstOrDefaultAsync(a => a.Id == id);

            return order;
        }
    }
}
