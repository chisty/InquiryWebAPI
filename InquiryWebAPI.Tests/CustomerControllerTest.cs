using InquiryWebAPI.Controllers;
using InquiryWebAPI.Models;
using InquiryWebAPI.Models.DbModels;
using InquiryWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace InquiryWebAPI.Tests
{
    public class CustomersControllerTest
    {        
        private readonly CustomersController _customerController;

        public CustomersControllerTest()
        {
            var dbContext = new FakeDbContextFactory().GetInMemoryDbCotext();
            var customerService = new CustomerService(dbContext);
            _customerController = new CustomersController(customerService);
        }

        
        [Fact]
        public void GetCustomers_ValidCustomerID_Returns_OkResult_With_Data()
        {
            var payload = new CustomerPayload {CustomerId = 1};
            var result = _customerController.GetCustomers(payload).Result;            
            var resultValue = (OkObjectResult) result;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<Customers>(resultValue.Value);
        }

        [Fact]
        public void GetCustomers_ValidEmail_Returns_OkResult_With_Data()
        {
            var payload = new CustomerPayload { Email = "tony@gmail.com" };
            var result = _customerController.GetCustomers(payload).Result;
            var resultValue = (OkObjectResult)result;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<Customers>(resultValue.Value);
        }

        [Fact]
        public void GetCustomers_Valid_But_Unknown_Email_Returns_NotFound()
        {
            var payload = new CustomerPayload {Email = "customer@gmail.com"};
            var result = _customerController.GetCustomers(payload).Result;            
            
            Assert.IsType<NotFoundResult>(result);            
        }


        [Fact]
        public void GetCustomers_Valid_But_Unknown_CustomerID_Returns_NotFound()
        {
            var payload = new CustomerPayload {CustomerId = 100};
            var result = _customerController.GetCustomers(payload).Result;            
            
            Assert.IsType<NotFoundResult>(result);            
        }
        
        [Fact]
        public void GetCustomers_InValid_Email_But_Valid_CustomerID_Returns_OkResult_With_Data()
        {
            var payload = new CustomerPayload {CustomerId = 1, Email = "invalidemail"};
            var result = _customerController.GetCustomers(payload).Result;
            var resultValue = (OkObjectResult)result;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<Customers>(resultValue.Value);
        }

        [Fact]
        public void GetCustomers_InValid_CustomerID_But_Valid_Email_Returns_OkResult_With_Data()
        {
            var payload = new CustomerPayload {CustomerId = -10, Email = "chisty@gmail.com"};
            var result = _customerController.GetCustomers(payload).Result;
            var resultValue = (OkObjectResult)result;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<Customers>(resultValue.Value);
        }


        [Fact]
        public void GetCustomers_Valid_Customer_Returns_Five_Transactions_Maximum()
        {
            var payload = new CustomerPayload {CustomerId = 2, Email = "chisty@gmail.com"};
            var result = _customerController.GetCustomers(payload).Result as OkObjectResult;
            var customers = (Customers)result.Value;
            
            Assert.Equal(5, customers.Transactions.Count);
        }


        




        
    }
}
