using BookContext.Domain.Exceptions;

namespace BookContext.Domain.Entities
{
    public class Author
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Cpf { get; private set; }

        public Author(string firstName, string lastName, string cpf)
        {
            AtribuiDadosDoAuthor(firstName, lastName, cpf);
        }

        private void AtribuiDadosDoAuthor(string firstName, string lastName, string cpf)
        {
            ValidaSePossuiFirstName(firstName);
            ValidaSePossuiLastName(lastName);
            ValidaSePossuiCPF(cpf);

            FirstName = firstName;
            LastName = lastName;
            Cpf = cpf;
        }

        private static void ValidaSePossuiFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new DomainException("Nome é uma informação obrigatória.");
        }
        
        private static void ValidaSePossuiLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new DomainException("Sobrenome é uma informação obrigatória.");
        }        

        private static void ValidaSePossuiCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                throw new DomainException("CPF é uma informação obrigatória.");
        }
    }
}