            //в Main метода например

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

            /*foreach (User user1 in users.List())
            {
                Console.WriteLine("{0} {1}", user1.UserId, user1.Username);
            }*/
