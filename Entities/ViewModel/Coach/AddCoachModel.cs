using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModel.Coach
{
    public class AddCoachModel
    {
        public string Name { get; set; }
        public Guid TeamId { get; set; }
    }
}
