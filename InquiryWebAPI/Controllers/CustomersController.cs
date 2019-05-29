using InquiryWebAPI.CustomAttribute;
using InquiryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using InquiryWebAPI.Models.DbModels;
using InquiryWebAPI.Services;

namespace InquiryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public ICustomerService CustomerService { get; set; }
        public CustomersController(ICustomerService customerService)
        {
            CustomerService = customerService;
        }

        // GET: api/Customers
        [HttpPost]
        [CustomValidationFilter]
        public ActionResult<Customers> GetCustomers([FromBody] CustomerPayload payload)
        {            
            var customer = CustomerService.GetCustomerById(payload.CustomerId);
            if (customer != null) return Ok(customer);

            customer = CustomerService.GetCustomerByEmail(payload.Email);
            if (customer != null) return Ok(customer);

            return NotFound();
        }

    }
}