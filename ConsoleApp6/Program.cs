using ConsoleApp6.Data;
using ConsoleApp6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {

            SampleDbContext dbContext= new SampleDbContext();///DB object


            Book book = new Book();
            book.ISBN = "01";
            book.Title = "onePlus";
            book.YearOfPublication = 1998;
            book.Price = 390;
            
            Author author = new Author();
            book.AutherId = author.Id;
            author.Name = "sharma";
            author.DateOfBirth = DateTime.Now;


            dbContext.Books.Add(book);
            dbContext.Authors.Add(author);
            dbContext.SaveChanges();//db save
            
            Console.WriteLine("done");
            Console.ReadKey();

        }
    }
}