using System;
using BookContext.Domain.Exceptions;

namespace BookContext.Domain.Entities
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }

        public Book(string title, string author, int year)
        {
            AtribuiDadosDoLivro(title, author, year);
        }

        private void AtribuiDadosDoLivro(string title, string author, int year) {
            ValidaDadosDoLivro(title, author, year);
            Title = title;
            Author = author;
            Year = year;       
        }

        private static void ValidaDadosDoLivro(string title, string author, int year) {
            VerificaSePossuiTitulo(title);
            VerificaSePossuiAuthor(author);
            ValidaSeAnoValido(year);
        }

        private static void VerificaSePossuiTitulo(string title) {
            if (string.IsNullOrWhiteSpace(title))
             throw new DomainException("Título do livro é uma informação obrigatória.");
        }

        private static void VerificaSePossuiAuthor(string author) {
            if (string.IsNullOrWhiteSpace(author))
             throw new DomainException("Author do livro é uma informação obrigatória.");
        }

        private static void ValidaSeAnoValido(int year) {
            if (year < 1500 || year > DateTime.Now.Year)
             throw new DomainException("Ano do livro inválido.");
        }
    }
}