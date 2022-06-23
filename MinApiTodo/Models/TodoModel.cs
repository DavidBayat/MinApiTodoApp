public class TodoModel
{
    public int Id { get; set; }
    public string TodoTitle { get; set; }
    public string TodoDescription { get; set; }
    public int Order { get; set; }
    public bool Finished { get; set; } = false;
}
