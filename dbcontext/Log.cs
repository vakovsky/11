    public class Log
    {
        public int LogId { get; set; }
        public string Info { get; set; }
        public DateTime Created { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
