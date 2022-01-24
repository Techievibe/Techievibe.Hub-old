using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Techievibe.Models.Api
{
    public class Transaction : RequestBase
    {
        /// <summary>
        /// Client applications need not populate this field, this is set to a new guid when we receive the transaction information.
        /// </summary>
        public string TransactionId { get; set; }
        
        [Required]
        public string Type { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }
        
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Account { get; set; }

    }
}
