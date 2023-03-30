using SimpleApi.Models;

namespace SimpleApi.Repositories;

public class BookRepository : IBookRepository
{
    private List<Book> Books = new List<Book>
    {
        new Book { Id = 1, Title = "1984", Author = "George Orwell" },
        new Book { Id = 2, Title = "Ready Player One", Author = "Ernest Cline" },
        new Book { Id = 3, Title = "The Martian", Author = "Andy Weir" },
    };

    public Book? GetById(int id)
    {
        return Books.Find(b => b.Id == id);
    }

    public List<Book> List()
    {
        return Books;
    }

    public Book Create(Book newBook)
    {
        Books.Add(newBook);
        return newBook;
    }

    public Book? Update(Book updatedBook)
    {
        var book = Books.Find(b => b.Id == updatedBook.Id);

        if (book == null)
            return null;

        book.Title = updatedBook.Title;
        book.Author = updatedBook.Author;

        return book;
    }

    public bool Delete(int id)
    {
        var book = Books.Find(b => b.Id == id);

        if (book == null)
            return false;

        Books.Remove(book);

        return true;
    }
}
