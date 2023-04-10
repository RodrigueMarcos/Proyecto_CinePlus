using System;
using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
	public class BookService : IBookService
	{
        private readonly CinePlusContext _context;

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return _context.Books.FirstOrDefault(book => book.ID == id);
        }

        public void SaveBook(BookDto bookDto)
        {
            var movScreening = _context.MovScreenings.Find(bookDto.movScreeningBookID);
            var client = _context.People.Find(bookDto.clientID);
            var createdBy = _context.People.Find(bookDto.createdByID);

            if (movScreening == null || client == null || createdBy == null)
            {
                throw new ArgumentException("Invalid input data.");
            }

            var book = new Book()
            {
                movScreeningBook = movScreening,
                client = client,
                qtySeats = bookDto.qtySeats,
                booking = bookDto.booking,
                createdAt = bookDto.createdAt,
                createdBy = createdBy,
                modifiedAt = bookDto.modifiedAt,
                modifiedBy = bookDto.modifiedByID != null ? _context.People.Find(bookDto.modifiedByID) : null
            };

            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(BookDto bookDto, int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.ID == id);

            if (book == null)
            {
                throw new ArgumentException("Book not found.");
            }

            var movScreeningBook = _context.MovScreenings.FirstOrDefault(ms => ms.ID == bookDto.movScreeningBookID);

            if (movScreeningBook == null)
            {
                throw new ArgumentException("MovScreening not found.");
            }

            var client = _context.People.FirstOrDefault(p => p.ID == bookDto.clientID);

            if (client == null)
            {
                throw new ArgumentException("Client not found.");
            }

            book.movScreeningBook = movScreeningBook;
            book.client = client;
            book.qtySeats = bookDto.qtySeats;
            book.booking = bookDto.booking;
            book.createdAt = bookDto.createdAt;

            var createdBy = _context.People.FirstOrDefault(p => p.ID == bookDto.createdByID);

            if (createdBy == null)
            {
                throw new ArgumentException("Created by person not found.");
            }

            book.createdBy = createdBy;
            book.modifiedAt = bookDto.modifiedAt;

            if (bookDto.modifiedByID.HasValue)
            {
                var modifiedBy = _context.People.FirstOrDefault(p => p.ID == bookDto.modifiedByID.Value);

                if (modifiedBy == null)
                {
                    throw new ArgumentException("Modified by person not found.");
                }

                book.modifiedBy = modifiedBy;
            }
            else
            {
                book.modifiedBy = null;
            }

            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                throw new ArgumentException("Book does not exist");
            }
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}

