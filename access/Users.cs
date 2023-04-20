public class Users
    {
        public void Create(User u)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User3\Documents\DatabaseDV.accdb";
            connection.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            cmd.CommandText = string.Format(
                "INSERT INTO Users ([Username], [Password])" +
                "VALUES ('{0}', '{1}')",
                u.Username, u.Password
                );
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public User Read(User u)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User3\Documents\DatabaseDV.accdb";
            connection.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            cmd.CommandText = string.Format(
                "SELECT [UserId],[Username],[Password] FROM Users " +
                "WHERE UserId = {0}",
                u.UserId
                );

            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                u.UserId = Convert.ToInt32(reader["UserId"]);
                u.Username = Convert.ToString(reader["Username"]);
                u.Password = Convert.ToString(reader["Password"]);
            }
            reader.Close();

            connection.Close();
            return u;
        }
        public void Update(User u)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User3\Documents\DatabaseDV.accdb";
            connection.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            cmd.CommandText = string.Format(
                "UPDATE Users " +
                "SET [Username] = '{1}', [Password] = '{2}' " +
                "WHERE UserId = {0}",
                u.UserId, u.Username, u.Password
                );
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public void Delete(User u)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User3\Documents\DatabaseDV.accdb";
            connection.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            cmd.CommandText = string.Format(
                "DELETE FROM Users " +
                "WHERE UserId = {0}",
                u.UserId
                );
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public List<User> List()
        {
            List<User> userlist = new List<User>();
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User3\Documents\DatabaseDV.accdb";
            connection.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            cmd.CommandText = string.Format(
                "SELECT [UserId],[Username],[Password] FROM Users"
                );

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User u = new User();
                u.UserId = Convert.ToInt32(reader["UserId"]);
                u.Username = Convert.ToString(reader["Username"]);
                u.Password = Convert.ToString(reader["Password"]);
                userlist.Add(u);
            }
            reader.Close();

            connection.Close();
            return userlist;
        }
    }
