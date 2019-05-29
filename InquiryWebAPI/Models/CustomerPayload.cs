using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryWebAPI.Models
{
    public class CustomerPayload
    {
        public decimal CustomerId { get; set; }        
        public string Email { get; set; }

        public CustomerPayload()
        {
            CustomerId= Decimal.MinValue;
            Email = string.Empty;
        }
    }

    public class CustomerPayload1
    {
        public decimal CustomerId { get; set; }        
    }

    public class CustomerPayload2
    {        
        public string Email { get; set; }
    }
}
