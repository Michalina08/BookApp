﻿using BookApp.Entities;
using BookApp.Repositories;
using BookApp.Data;


var bookRepository = new SqlRepository<Book>(new BookAppDbContext());

AddBook(bookRepository);
AddTextbooks(bookRepository);
WriteAllToConsole(bookRepository);

static void AddBook(IRepository<Book> bookRepository)
{
    bookRepository.Add(new Book { Title = "Ala" });
    bookRepository.Add(new Book { Title = "Lena" });
    bookRepository.Add(new Book { Title = "Natalia" });
    bookRepository.Save();
}
static void AddTextbooks(IWriteRepository<Textbooks> textbookRepository)
{
    textbookRepository.Add(new Textbooks { Title = "Lena" });
    textbookRepository.Add(new Textbooks { Title = "Natalia" });
    textbookRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }

}