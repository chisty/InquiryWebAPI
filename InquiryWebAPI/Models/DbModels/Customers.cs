using System;
using System.Collections.Generic;

namespace InquiryWebAPI.Models.DbModels
{
    public partial class Customers
    {
        public Customers()
        {
            Transactions = new HashSet<Transactions>();
        }

        public decimal CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal? Mobile { get; set; }

        public ICollection<Transactions> Transactions { get; set; }
    }
}
