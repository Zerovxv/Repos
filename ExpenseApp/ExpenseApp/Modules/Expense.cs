﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseApp.Modules
{
    public class Expense
    { public int Id { get; set; }
        [StringLength(80)]
        public string Description { get; set; }
        
        [StringLength(10)]
        public string Status { get; set; }
     
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
       
        public int EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }

        public virtual IEnumerable<Expenseline> Expenseline { get; set; }

    }
}
