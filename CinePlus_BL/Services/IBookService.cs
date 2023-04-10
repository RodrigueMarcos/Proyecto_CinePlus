using CinePlus_BL.Dtos;
using CinePlus_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinePlus_BL.Services
{
    public interface IBookService
    {
        public IEnumerable<Book> GetBooks();
        public Book GetBook(int id);
        public void SaveBook(BookDto bookDto);
        public void UpdateBook(BookDto bookDto, int id);
        public void DeleteBook(int id);
    }
}