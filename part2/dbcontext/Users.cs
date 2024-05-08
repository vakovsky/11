class Users
    {
        public void Create(User user)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public User Read(User user)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                user = (from u in context.Users
                     where u.UserId == user.UserId
                     select u
                ).Single();
                return user;
            }
        }

        public void Update(User user)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                User userold = (
                    from u in context.Users
                    where u.UserId == user.UserId
                    select u
                ).Single();
                userold.Username = user.Username;
                userold.Password = user.Password;
                context.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                User userold = (
                    from u in context.Users
                    where u.UserId == user.UserId
                    select u
                ).Single();
                context.Users.Remove(userold);
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
