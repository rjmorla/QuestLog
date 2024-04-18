namespace api.Models
{
    public class Quest
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public List<Subtask> Subtasks = new List<Subtask>();
    }
}