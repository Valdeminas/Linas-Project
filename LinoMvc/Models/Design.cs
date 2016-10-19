using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LinoMvc.Models
{
    public class Design
    {
        [StringLength(4)]
        [RegularExpression(@"^[A-Z]{4}$")]
        public string SKU { get; set; }
    }
}