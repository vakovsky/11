    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Index(IsUnique = true), Required]
        [StringLength(200)]
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
        public DataBaseContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mitko\Documents\databaseCF.mdf;Integrated Security=True;Connect Timeout=30") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
    }

    class Users
    {
        public void Create(User u)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                context.Users.Add(u);
                context.SaveChanges();
            }
        }

        public User Read(User u)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                u = (from user in context.Users
                     where user.UserId == u.UserId
                     select user).Single();
                return u;
            }
        }

        public void Update(User u)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                User user = (from userold in context.Users
                             where userold.UserId == u.UserId
                             select userold).Single();
                user.Username = u.Username;
                user.Password = u.Password;
                context.SaveChanges();
            }
        }

        public void Delete(User u)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                User user = (from userold in context.Users
                             where userold.UserId == u.UserId
                             select userold).Single();
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users();
            User user = new User();

            Console.Write("Username:");
            user.Username = Console.ReadLine();
            Console.Write("Password:");
            user.Password = Console.ReadLine();
            users.Create(user);

            /*Console.Write("UserId:");
            user.UserId = int.Parse(Console.ReadLine());
            users.Delete(user);*/

            /*Console.Write("UserId:");
            user.UserId = int.Parse(Console.ReadLine());
            Console.Write("Username:");
            user.Username = Console.ReadLine();
            Console.Write("Password:");
            user.Password = Console.ReadLine();
            users.Update(user);*/

            /*Console.Write("UserId:");
            user.UserId = int.Parse(Console.ReadLine());
            user = users.Read(user);
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);*/
        }
    }

//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;
