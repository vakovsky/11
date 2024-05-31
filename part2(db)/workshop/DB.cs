using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WindowsFormsApp3
{
    public class DB : DbContext
    {
        public DB() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User3\source\repos\SolutionDB3\WindowsFormsApp3\Database1.mdf;Integrated Security=True;Connect Timeout=30") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}

public class User
{
    [Key]
    public int UserId { get; set; }
    [Index(IsUnique = true), Required]
    [StringLength(200)]
    public string Username { get; set; }
    public string Password { get; set; }
    //
    public int GroupId { get; set; }
    public virtual Group Group { get; set; }
    //
    public virtual List<Log> Logs { get; set; }

    public override string ToString()
    {
        return Username + " (" + UserId.ToString() + ") (" + GroupId.ToString() + ")";
    }
}

public class Log
{
    public int LogId { get; set; }
    public string Info { get; set; }
    public DateTime Created { get; set; }
    //
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public override string ToString()
    {
        return Info + " " + Created.ToString();
    }
}

public class Group
{
    [Key]
    public int GroupId { get; set; }
    [Index(IsUnique = true), Required]
    [StringLength(200)]
    public string Groupname { get; set; }
    //
    public virtual List<User> Users { get; set; }

    public override string ToString()
    {
        return Groupname;
    }
}
