using SimpleApi.Models;
using SimpleApi.Repositories;

namespace SimpleApi.Endpoints;

public class BookEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("/books", List);
        app.MapGet("/books/{id}", GetBookById);
        app.MapPost("/books", Create);
        app.MapPut("/books/{id}", Update);
        app.MapDelete("/books/{id}", Delete);
    }

    private static IResult GetBookById(IBookRepository repository, int id)
    {
        var book = repository.GetById(id);
        return book == null ? Results.NotFound("book.id.not_found") : Results.Ok(book);
    }
    
    private static IResult List(IBookRepository repository)
    {
        var books = repository.List();
        return Results.Ok(books);
    }

    private static IResult Create(IBookRepository repository, Book newBook)
    {
        var book = repository.Create(newBook);
        return Results.Ok(book);
    }

    private static IResult Update(IBookRepository repository, Book updatedBook)
    {
        var book = repository.Update(updatedBook);
        return book == null ? Results.NotFound("book.id.not_found") : Results.Ok(book);
    }

    private static IResult Delete(IBookRepository repository, int id)
    {
        var book = repository.Delete(id);
        return book ? Results.Ok() : Results.NotFound("book.id.not_found") ;
    }
}
