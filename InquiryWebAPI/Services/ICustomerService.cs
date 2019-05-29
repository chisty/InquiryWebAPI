using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InquiryWebAPI.Models.DbModels;

namespace InquiryWebAPI.Services
{
    public interface ICustomerService
    {
        Customers GetCustomerByEmail(string email);
        Customers GetCustomerById(decimal customerId);
    }
}
