namespace BookContext.Domain
{
    public class Author
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Cpf { get; private set; }

        public Author(string firstName, string lastName, string cpf)
        {
            FirstName = firstName;
            LastName = lastName;
            Cpf = cpf;        
        }
    }

}