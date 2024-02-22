var user1 = new User();
System.Console.Write($"Enter your FirstName: ");
user1.FirstName = Console.ReadLine();
System.Console.Write($"Enter your LastName: ");
user1.LastName = Console.ReadLine();
System.Console.Write($"Enter username: ");
user1.UserName = Console.ReadLine();
System.Console.Write($"Make a Password! : ");
user1.Password = Console.ReadLine();

user1.LogIn();

System.Console.WriteLine(user1.GetFullInfo());
user1.Logout();