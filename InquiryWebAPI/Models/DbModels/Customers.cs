using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InquiryWebAPI.Models.DbModels
{
    public partial class Customers
    {
        public Customers()
        {
            Transactions = new HashSet<Transactions>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CustomerId { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Invalid email.")]
        [MaxLength(25, ErrorMessage = "Email should not be more than 25 characters in length.")]
        public string Email { get; set; }
        public decimal? Mobile { get; set; }

        public ICollection<Transactions> Transactions { get; set; }
    }
}
