using SimpleApi.Endpoints;
using SimpleApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IBookRepository, BookRepository>();

var app = builder.Build();

BookEndpoints.Map(app);

app.Run();
