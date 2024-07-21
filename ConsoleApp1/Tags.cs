namespace ConsoleApp1;

public class Tags
{
    public int Id { get; set; }
    public string Tag { get; set; }

    public List<Posts> posts { get; set; }
    public override string ToString()
    {
        return $"{Tag}";
    }
}
