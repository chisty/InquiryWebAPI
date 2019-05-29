using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryWebAPI.Models
{
    public class CustomerPayload
    {
        public decimal CustomerId { get; set; }
        public string Email { get; set; }
    }
}
