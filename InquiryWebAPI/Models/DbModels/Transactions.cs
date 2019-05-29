using System;
using System.Collections.Generic;

namespace InquiryWebAPI.Models.DbModels
{
    public partial class Transactions
    {
        public decimal Id { get; set; }
        public decimal CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string Status { get; set; }

        public Customers Customer { get; set; }
    }
}
