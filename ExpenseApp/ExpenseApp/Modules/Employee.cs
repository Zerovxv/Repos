using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExpenseApp.Modules
{
    
    public class Employee
    {
        [Key]
        [StringLength(30)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
       
        public string Password { get; set; }
     
        public bool Admin { get; set; }

        [Column(TypeName = "decimal(11,2)")]
        public decimal ExpensesDue { get; set; }

        [Column(TypeName = "decimal(11,2)")]
        public decimal ExpensesPaid { get; set; }


        [JsonIgnore]
        public virtual IEnumerable<Expense> Expenses { get; set; }

    }
}
