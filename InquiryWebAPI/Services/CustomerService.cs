using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InquiryWebAPI.Models.DbModels;

namespace InquiryWebAPI.Services
{
    public class CustomerService: ICustomerService
    {

        public CustomerService(AppDbContext context)
        {
            DbContext = context;
        }

        public AppDbContext DbContext { get; set; }
    }
}
