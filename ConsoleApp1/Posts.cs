namespace ConsoleApp1;

public class Posts
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; } = DateTime.Now;

    public string? Text { get; set; }

    public string ImagePath { get; set; }

    public List<Tags> tags { get; set; }
    public override string ToString()
    {
        return $"{Id}: {ImagePath}\n{Text}\n{DateTime} {tags}";
    }
}
