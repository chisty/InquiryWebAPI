using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InquiryWebAPI.Helpers;
using InquiryWebAPI.Models.DbModels;

namespace InquiryWebAPI.Services
{
    public class CustomerService: ICustomerService
    {
        public Customers GetCustomerByEmail(string email)
        {
            var customer = DbContext.Customers.FirstOrDefault(c => c.Email.IsEqual(email));
            if (customer == null) return null;

            var transactions = GetTransactionsByCustomerId(customer.CustomerId);
            customer.Transactions = transactions;

            return customer;
        }

        public Customers GetCustomerById(decimal customerId)
        {
            var customer = DbContext.Customers.FirstOrDefault(c => c.CustomerId.Equals(customerId));
            if (customer == null) return null;

            var transactions = GetTransactionsByCustomerId(customerId);
            customer.Transactions = transactions;

            return customer;
        }


        private List<Transactions> GetTransactionsByCustomerId(decimal customerId)
        {
            var transactions = DbContext.Transactions.Where(t => t.CustomerId.Equals(customerId)).OrderByDescending(o => o.Date).Take(5).ToList();
            return transactions;
        }



        public CustomerService(AppDbContext context)
        {
            DbContext = context;
        }

        public AppDbContext DbContext { get; set; }
    }
}
