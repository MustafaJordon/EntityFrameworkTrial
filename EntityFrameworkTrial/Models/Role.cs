using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTrial.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int EmployeeId { get; set; }     //Foreign Key in one to one relationship
        //public Employee Employee { get; set; }  //Navigation Property to table Employees
    }
}
