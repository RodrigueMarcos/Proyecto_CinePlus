using CinePlus_BL.Dtos;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        void SaveBook(BookDTO bookDto);
        void UpdateBook(BookDTO bookDto, int id);
        void DeleteBook(int id);
    }
}