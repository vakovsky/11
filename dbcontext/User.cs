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
