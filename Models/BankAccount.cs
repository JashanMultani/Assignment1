using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class BankAccount
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AccountNumber { get; set; }

        public string PersonName { get; set; }

        public int AccountBalance { get; set; }
    }
}
