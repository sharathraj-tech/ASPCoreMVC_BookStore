using Cloudhostica.BookStore.Models;
using Cloudhostica.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cloudhostica.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int? Id)
        {
            var data = _bookRepository.GetBookById(Id);
            ViewBag.Title = "Book Store - Book Details - "+data.Title;
            return View(data);
        }

        public List<BookModel> SearchBookByName(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
