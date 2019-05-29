using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InquiryWebAPI.CustomAttribute;
using InquiryWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [ValidateInquiry]
        public IActionResult GetCustomers([FromBody] CustomerPayload payload)
        {            
            if (payload.CustomerId > 0M)
            {
                var customer = CustomerService.GetCustomerById(payload.CustomerId);
                if (customer != null) return Ok(customer);
            }

            if (string.IsNullOrWhiteSpace(payload.Email) == false)
            {
                var customer = CustomerService.GetCustomerByEmail(payload.Email);
                return customer == null ? (IActionResult)NotFound() : Ok(customer);
            }


            return BadRequest();
        }

    }
}