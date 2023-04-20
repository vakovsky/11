public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public virtual List<Log> Logs { get; set; }
}
public class Log
{
    public int LogId { get; set; }
    public string Info { get; set; }
    public DateTime Created { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
public class DataBaseContext : DbContext
{
    public DataBaseContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User3\Documents\databaseCF.mdf;Integrated Security=True;Connect Timeout=30") { }
    public DbSet<User> Users { get; set; }
    public DbSet<Log> Logs { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        using (DataBaseContext context = new DataBaseContext())
        {
            User user = new User();
            Console.Write("Username:");
            user.Username = Console.ReadLine();
            Console.Write("Password:");
            user.Password = Console.ReadLine();
            context.Users.Add(user);
            context.SaveChanges();
        }

        /*using (DataBaseContext context = new DataBaseContext())
        {
            Console.Write("UserId:");
            int id = int.Parse(Console.ReadLine());
            var user = (from u in context.Users
                        where u.UserId == id
                        select u).Single();
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);
        }*/

        /*using (DataBaseContext context = new DataBaseContext())
        {
            Console.Write("UserId:");
            int id = int.Parse(Console.ReadLine());
            User user = (from u in context.Users
                        where u.UserId == id
                        select u).Single();
            user.Username = "user36";
            user.Password = "pass36";
            context.SaveChanges();
        }*/

        /*using (DataBaseContext context = new DataBaseContext())
        {
            Console.Write("UserId:");
            int id = int.Parse(Console.ReadLine());
            User user = (from u in context.Users
                        where u.UserId == id
                        select u).Single();
            context.Users.Remove(user);
            context.SaveChanges();
        }*/
    }
}
