namespace BookContext.Domain
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;       
        }
    }
}