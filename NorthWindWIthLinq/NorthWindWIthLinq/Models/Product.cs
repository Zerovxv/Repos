using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWIthLinq.Models
{
    public class Product
    { public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }

        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? RecorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public override string ToString()
        {
            return $"ProductId : {ProductId}\n" +
                $"ProductName : {ProductName}\n";

            
            
        }
        
    }
}  
  