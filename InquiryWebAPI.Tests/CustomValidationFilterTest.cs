using System;
using System.Collections.Generic;
using System.Text;
using InquiryWebAPI.Controllers;
using InquiryWebAPI.CustomAttribute;
using InquiryWebAPI.Models;
using InquiryWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Xunit;

namespace InquiryWebAPI.Tests
{
    public class CustomValidationFilterTest
    {
        private readonly CustomersController _customerController;

        public CustomValidationFilterTest()
        {
            var dbContext = new FakeDbContextFactory().GetInMemoryDbCotext();
            var customerService = new CustomerService(dbContext);
            _customerController = new CustomersController(customerService);
        }

        [Fact]
        public void CustomFilter_EmptyRequest_Returns_BadRequest_With_NoInquiryCriteriaMessage()
        {
            var payload = new CustomerPayload();
            var customValidationFilter = new CustomValidationFilter();
            var actionContext = new ActionContext(new DefaultHttpContext(), new RouteData(), new ActionDescriptor());
            var actionExecutingContext = new ActionExecutingContext(actionContext, new List<IFilterMetadata>()
                , new Dictionary<string, object>() { { "payload", payload } }, _customerController);

            customValidationFilter.OnActionExecuting(actionExecutingContext);

            Assert.IsType<BadRequestObjectResult>(actionExecutingContext.Result);
            Assert.Equal("No inquiry criteria.", ((BadRequestObjectResult)actionExecutingContext.Result).Value.ToString());
        }

        [Fact]
        public void CustomFilter_Invalid_CustomerID_Returns_BadRequest_With_Invalid_Customer_Message()
        {
            var payload = new CustomerPayload {CustomerId = -10};
            var customValidationFilter = new CustomValidationFilter();
            var actionContext = new ActionContext(new DefaultHttpContext(), new RouteData(), new ActionDescriptor());
            var actionExecutingContext = new ActionExecutingContext(actionContext, new List<IFilterMetadata>()
                , new Dictionary<string, object>() { { "payload", payload } }, _customerController);

            customValidationFilter.OnActionExecuting(actionExecutingContext);

            Assert.IsType<BadRequestObjectResult>(actionExecutingContext.Result);
            Assert.Equal("Invalid Customer ID.", ((BadRequestObjectResult)actionExecutingContext.Result).Value.ToString());
        }

        [Fact]
        public void CustomFilter_Invalid_Email_Returns_BadRequest_With_Invalid_Email_Message()
        {
            var payload = new CustomerPayload {Email = "invalidemail"};
            var customValidationFilter = new CustomValidationFilter();
            var actionContext = new ActionContext(new DefaultHttpContext(), new RouteData(), new ActionDescriptor());
            var actionExecutingContext = new ActionExecutingContext(actionContext, new List<IFilterMetadata>()
                , new Dictionary<string, object>() { { "payload", payload } }, _customerController);

            customValidationFilter.OnActionExecuting(actionExecutingContext);

            Assert.IsType<BadRequestObjectResult>(actionExecutingContext.Result);
            Assert.Equal("Invalid Email.", ((BadRequestObjectResult)actionExecutingContext.Result).Value.ToString());
        }
    }
}
