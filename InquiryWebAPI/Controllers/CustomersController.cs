using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult GetCustomers([FromBody] CustomerPayload payload)
        {
            if (string.IsNullOrWhiteSpace(payload.Email) && payload.CustomerId == decimal.MinValue)
            {
                return BadRequest("No inquiry criteria.");
            }

            if (payload.CustomerId > decimal.MinValue && payload.CustomerId <= 0M)
            {
                return BadRequest("Invalid Customer ID.");
            }

            if (payload.CustomerId > 0M)
            {
                var customer = CustomerService.GetCustomerById(payload.CustomerId);
                return customer == null ? (IActionResult) NotFound() : Ok(customer);
            }

            if (string.IsNullOrWhiteSpace(payload.Email) == false)
            {
                if (new EmailAddressAttribute().IsValid(payload.Email) == false) return BadRequest("Invalid Email.");

                var customer = CustomerService.GetCustomerByEmail(payload.Email);
                return customer == null ? (IActionResult) NotFound() : Ok(customer);
            }

            return BadRequest();
        }

    }
}