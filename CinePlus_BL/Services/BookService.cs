using CinePlus_BL.Dtos;
using CinePlus_BL.Services;
using CinePlus_DAL;
using CinePlus_DAL.Models;

public class BookService : IBookService
{
    private readonly CinePlusDBContext _context;

    public BookService(CinePlusDBContext context)
    {
        _context = context;
    }

    public IEnumerable<Book> GetBooks()
    {
        return _context.Books.ToList();
    }

    public Book GetBook(int id)
    {
        return _context.Books.FirstOrDefault(book => book.ID == id);
    }

    public void SaveBook(BookDTO bookDto)
    {
        var movScreening = _context.MovScreenings.Find(bookDto.MovScreeningID);
        var client = _context.People.Find(bookDto.ClientID);
        var createdBy = _context.People.Find(bookDto.CreatedById);

        if (movScreening == null || client == null || createdBy == null)
        {
            throw new ArgumentException("Invalid input data.");
        }

        var book = new Book()
        {
            MovScreeningID = movScreening.ID,
            ClientID = client.ID,
            qtySeats = bookDto.QtySeats,
            firstSeat = bookDto.FirstSeat,
            createdAt = DateTime.Now,
            CreatedById = createdBy.ID,
        };

        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void UpdateBook(BookDTO bookDto, int id)
    {
        var book = _context.Books.FirstOrDefault(book => book.ID == id);

        if (book == null)
        {
            throw new ArgumentException("Book not found.");
        }

        var movScreening = _context.MovScreenings.FirstOrDefault(movscreening => movscreening.ID == bookDto.MovScreeningID);

        if (movScreening == null)
        {
            throw new ArgumentException("MovScreening not found.");
        }

        var client = _context.People.FirstOrDefault(person => person.ID == bookDto.ClientID);

        if (client == null)
        {
            throw new ArgumentException("Client not found.");
        }

        book.MovScreeningID = movScreening.ID;
        book.ClientID = client.ID;
        book.qtySeats = bookDto.QtySeats;
        book.firstSeat = bookDto.FirstSeat;
        book.modifiedAt = DateTime.Now;

            var modifiedBy = _context.People.FirstOrDefault(person => person.ID == bookDto.ModifiedById.Value);

            if (modifiedBy == null)
            {
                throw new ArgumentException("Modified by person not found.");
            }
            book.ModifiedById = bookDto.ModifiedById.Value;

        _context.SaveChanges();
    }

    public void DeleteBook(int id)
    {
        var book = _context.Books.FirstOrDefault(book => book.ID == id);

        if (book == null)
        {
            throw new ArgumentException("Book not found.");
        }

        _context.Books.Remove(book);
        _context.SaveChanges();
    }
}


