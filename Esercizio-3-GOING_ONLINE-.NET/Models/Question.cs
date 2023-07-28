namespace Esercizio_3_GOING_ONLINE_.NET.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
