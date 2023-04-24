    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\databaseCF.mdf;Integrated Security=True;Connect Timeout=30") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
