using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Team
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public ICollection<Player> Players { get; set; }
        public virtual Coach Coach { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDateOnUTC { get; set; }
        public DateTime? ModifiedDateOnUTC { get; set; }
    }
}
