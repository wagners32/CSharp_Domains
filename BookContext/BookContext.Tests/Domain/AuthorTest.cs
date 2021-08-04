using Xunit;
using BookContext.Domain.Exceptions;
using BookContext.Domain.Entities;

namespace BookContext.Tests.Domain
{
    public class AuthorTest
    {

        private readonly static string _first_name = "João";
        private readonly static string _last_name = "da Silva";
        private readonly static string _cpf = "42773199472";

        [Fact]
        public void Author_QuandoCriado_DeveAtribuirDados()
        {
            // given
            var author = new Author(firstName: _first_name, lastName: _last_name, cpf: _cpf);

            // assert
            Assert.True(author.FirstName == _first_name);
            Assert.True(author.LastName == _last_name);
            Assert.True(author.Cpf == _cpf);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)] 
        public void Author_DadoFirstNameVazioOuNulo_QuandoCriar_DeveRetornarUmaDomainException(string firstName)
        {
            Assert.Throws<DomainException>(() => new Author(firstName: firstName, lastName: _last_name, cpf: _cpf));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)] 
        public void Author_DadoLastNameVazioOuNulo_QuandoCriar_DeveRetornarUmaDomainException(string lastName)
        {
            Assert.Throws<DomainException>(() => new Author(firstName: _first_name, lastName: lastName, cpf: _cpf));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)] 
        public void Author_DadoCpfVazioOuNulo_QuandoCriar_DeveRetornarUmaDomainException(string cpf)
        {
            Assert.Throws<DomainException>(() => new Author(firstName: _first_name, lastName: _last_name, cpf: cpf));
        }
    }
}
