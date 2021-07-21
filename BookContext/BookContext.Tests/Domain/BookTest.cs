using System;
using Xunit;
using BookContext.Domain;
using BookContext.Domain.Exceptions;

namespace BookContext.Tests.Domain
{
    public class BookTest
    {

        private readonly static string _title = "Livro Um";
        private readonly static string _author = "João Maria";
        private readonly static int _actualYear = DateTime.Now.Year;

        [Fact]
        public void Book_QuandoCriado_DeveAtribuirDados()
        {
            // given
            var book = new Book(title: _title, author: _author, year: _actualYear);

            // assert
            Assert.True(book.Title == _title);
            Assert.True(book.Author == _author);
            Assert.True(book.Year == _actualYear);
        }
        
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void QuandoTitleNuloOuVazio_DeveLancarDomainException(string title)
        {
            Assert.Throws<DomainException>(() => new Book(title: title, author: _author, year: _actualYear));
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void QuandoAuthorNuloOuVazio_DeveLancarDomainException(string author_test)
        {
            Assert.Throws<DomainException>(() => new Book(title: _title, author: author_test, year: _actualYear));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(999)]
        [InlineData(-2021)]
        public void QuandoAnoINvalido_DeveLancarDomainException(int year_test)
        {
            Assert.Throws<DomainException>(() => new Book(title: _title, author: _author, year: year_test));
        }

        [Fact]
        public void QuandoAnoSuperiorAoAtual_DeveLancarDomainException()
        {
            Assert.Throws<DomainException>(() => new Book(title: _title, author: _author, year: DateTime.Now.AddYears(1).Year));
        }       
    }
}
