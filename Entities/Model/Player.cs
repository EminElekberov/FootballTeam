using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public Team Team { get; set; }
        public Guid TeamId { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDateOnUTC { get; set; }
        public DateTime? ModifiedDateOnUTC { get; set; }
    }
}
