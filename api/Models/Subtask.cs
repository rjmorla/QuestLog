namespace api.Models
{
    public class Subtask
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int? QuestId { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public Quest? Quest { get; set; }
    }
}