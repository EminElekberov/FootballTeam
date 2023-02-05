using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Coach
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual Team Team { get; set; }
        public Guid TeamId { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDateOnUTC { get; set; }
        public DateTime? ModifiedDateOnUTC { get; set; }
    }
}
