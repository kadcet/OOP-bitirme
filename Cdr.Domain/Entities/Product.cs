using Cdr.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdr.Domain.Entities
{
    public class Product : AuditEntity
    {
        public string Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public decimal Tax { get; set; }

        // sınıfın içindeki vergi oranıyla fiyatın çarpılarak elde edildiği bir propert olsun
        public decimal IncludingTax { get => Price * Convert.ToDecimal(Tax); }

        // Her ürün bir category e dahildir
        public string CategoryId { get; set; }

        
    }
}
