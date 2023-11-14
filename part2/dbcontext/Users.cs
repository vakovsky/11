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
        public List<User> List()
        {
            List<User> users = null;
            using (var context = new DataBaseContext())
            {
                users = (from u in context.Users
                         orderby u.UserId
                         select u).ToList();
            }
            return users;
        }
    }
