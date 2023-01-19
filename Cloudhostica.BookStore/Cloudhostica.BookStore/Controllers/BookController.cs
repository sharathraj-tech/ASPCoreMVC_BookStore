using Microsoft.AspNetCore.Mvc;

namespace Cloudhostica.BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }

        public string GetBook(int Id)
        {
            return $"Book with Id= {Id}";
        }

        public string SearchBookByName(string bookName,string authorName)
        {
            return $"{bookName} was written by {authorName}";
        }
    }
}
