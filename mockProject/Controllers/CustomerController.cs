using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using mockProject.Interfaces;
using mockProject.Persistences.Mssql;
using mockProject.ViewModels;

namespace mockProject.Controllers
{
    [Route("api/v1/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<CustomerViewModel>>> GetAll()
        {
            var customerList = await _customerService.GetAllCustomers();

            var customerListViewModel = _mapper.Map<List<CustomerViewModel>>(customerList);

            return Ok(customerListViewModel);
        }

        [HttpPost("create")]
        public async Task<ActionResult<CustomerViewModel>> CreateCustomer(Customer customer)
        {
            var addedCustomer = await _customerService.CreateCustomer(customer);

            var addedCustomerViewModel = _mapper.Map<List<CustomerViewModel>>(addedCustomer);

            return Ok(addedCustomerViewModel);
        }
    }
}
