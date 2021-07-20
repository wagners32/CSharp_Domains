using System;
using Xunit;
using BookContext.Domain;

namespace BookContext.Tests.Domain
{
    public class BookTest
    {
        [Fact]
        public void Book_QuandoCriado_DeveAtribuirDados()
        {
            // given
            var book = new Book(title: "Teste", author: "Wagner", year: 2021);

            // assert
            Assert.True(book.Title == "Teste");
            Assert.True(book.Author == "Wagner");
            Assert.True(book.Year == 2021);
        }
    }
}
