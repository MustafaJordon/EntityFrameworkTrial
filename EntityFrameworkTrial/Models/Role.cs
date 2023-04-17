using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTrial.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Employee Employee { get; set; }
    }
}
