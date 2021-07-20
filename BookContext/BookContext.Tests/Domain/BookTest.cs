using System;
using Xunit;
using BookContext.Domain;
using BookContext.Domain.Exceptions;

namespace BookContext.Tests.Domain
{
    public class BookTest
    {
        [Fact]
        public void Book_QuandoCriado_DeveAtribuirDados()
        {
            // given
            var book = new Book(title: "Livro Um", author: "João Maria", year: 2021);

            // assert
            Assert.True(book.Title == "Livro Um");
            Assert.True(book.Author == "João Maria");
            Assert.True(book.Year == 2021);
        }
        
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void QuandoTitleNuloOuVazio_DeveLancarDomainException(string title)
        {
            Assert.Throws<DomainException>(() => new Book(title: title, author: "João Maria", year: 2021));
        } 
       
    }
}
