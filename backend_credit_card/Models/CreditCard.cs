using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend_credit_card.Models
{
    public class CreditCard
    {
        public int Id { get; set; }

        [Required]
        public string Owner { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string Expire_date { get; set; }


    }
}
