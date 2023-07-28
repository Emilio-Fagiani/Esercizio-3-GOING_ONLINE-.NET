    namespace Esercizio_3_GOING_ONLINE_.NET.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsAccepted { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
