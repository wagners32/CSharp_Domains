using System;
using Xunit;
using BookContext.Domain;
using BookContext.Domain.Exceptions;

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
    }
}
