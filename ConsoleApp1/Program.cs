using ConsoleApp1;

UserContex db = new UserContex();

User user = new User() { Login = "Maga1090", Password = "12345" };

db.Add(user);
db.SaveChanges();