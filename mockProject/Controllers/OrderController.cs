using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using mockProject.Interfaces;
using mockProject.ViewModels;

namespace mockProject.Controllers
{
    [Route("api/v1/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<OrderViewModel>>> GetAll()
        {
            var orderList = await _orderService.GetAllOrders();

            var orderListViewModel = _mapper.Map<List<OrderViewModel>>(orderList);

            return Ok(orderListViewModel);
        }

        [HttpGet("get-by-id")]
        public async Task<ActionResult<IEnumerable<OrderViewModel>>> GetById(int id)
        {
            var order = await _orderService.GetOrderById(id);

            var orderViewModel = _mapper.Map<OrderViewModel>(order);

            return Ok(orderViewModel);
        }
    }
}
