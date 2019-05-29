using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace InquiryWebAPI.Models.DbModels
{
    public partial class Transactions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        [JsonIgnore]
        [Required(ErrorMessage = "Invalid customer Id.")]        
        public decimal CustomerId { get; set; }
        [Required(ErrorMessage = "Invalid transaction datetime.")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Invalid amount.")]        
        public decimal Amount { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Currency code should not be more than 10 characters in length.")]        
        public string CurrencyCode { get; set; }
        public string Status { get; set; }

        public Customers Customer { get; set; }
    }
}
