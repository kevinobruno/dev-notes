using SimpleApi.Models;

namespace SimpleApi.Repositories;

public interface IBookRepository
{
    public Book? GetById(int id);
    public List<Book> List();
    public Book Create(Book newBook);
    public Book? Update(Book updatedBook);
    public bool Delete(int id);
}
