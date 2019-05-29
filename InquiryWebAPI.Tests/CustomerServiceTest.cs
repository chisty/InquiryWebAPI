using System;
using System.Linq;
using InquiryWebAPI.Services;
using Xunit;

namespace InquiryWebAPI.Tests
{
    public class CustomerServiceTest
    {
        private readonly ICustomerService _customerService;

        public CustomerServiceTest()
        {
            var dbContext = new FakeDbContextFactory().GetInMemoryDbCotext();
            _customerService = new CustomerService(dbContext);
        }

        [Fact]
        public void GetCustomerByEmail_Returns_NotNull()
        {            
            var customer = _customerService.GetCustomerByEmail("chisty@gmail.com");
            Assert.NotNull(customer);
        }

        [Fact]
        public void GetCustomerByEmail_Returns_Null()
        {            
            var customer = _customerService.GetCustomerByEmail("invalid@gmail.com");
            Assert.Null(customer);
        }

        [Fact]
        public void GetCustomerByCustomerID_Returns_NotNull()
        {
            var customer = _customerService.GetCustomerById(2);
            Assert.NotNull(customer);
        }

        [Fact]
        public void GetCustomerByEmail_Returns_Customer_With_ThreeTransactions()
        {
            var customer = _customerService.GetCustomerByEmail("tony@gmail.com");
            Assert.Equal(3, customer.Transactions.Count);
        }


        [Fact]
        public void GetCustomerByEmail_Returns_Customer_With_FiveTransactions()
        {
            var customer = _customerService.GetCustomerByEmail("chisty@gmail.com");
            Assert.Equal(5, customer.Transactions.Count);
        }

        [Fact]
        public void GetCustomerByEmail_Returns_Customers_Own_Transactions()
        {
            var customer = _customerService.GetCustomerByEmail("chisty@gmail.com");
            var transaction = customer.Transactions.First();
            Assert.Equal(customer.CustomerId, transaction.CustomerId);
        }        

    }
}
