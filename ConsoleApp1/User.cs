namespace ConsoleApp1;

public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public DateTime DateTime { get; set; }
    public bool IsOpen { get; set; } = true;

    public bool Gender { get; set; } = true;

    public List<Posts> posts { get; set; }
    public override string ToString()
    {
        return @$"{Id}: {Login} | {Gender} | {DateTime} | {IsOpen} 
                  Posts:
                  {posts}";
    }
}
