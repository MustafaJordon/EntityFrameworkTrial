namespace EntityFrameworkTrial.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Role Roles { get; set; }       //Reference navigation property to table Roles
    }
}
