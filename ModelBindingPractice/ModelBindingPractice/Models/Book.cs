namespace ModelBindingPractice.Models
{
    public class Book
    {
        public int? BookId { get; set; }

        public string? Author { get; set; }


        public override string ToString()
        {
            return $"Bookid = {BookId}, Author = {Author}";
        }
    }
}
