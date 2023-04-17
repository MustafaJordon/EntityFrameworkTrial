using EntityFrameworkTrial;

try
{
    var _context = new ApplicationDbContext();
    _context.SaveChanges();
}
catch(Exception ex)
{
    Console.WriteLine($"ERROR : {ex.InnerException.Message}");
}


