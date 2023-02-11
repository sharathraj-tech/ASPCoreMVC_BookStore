using Cloudhostica.BookStore.Models;

namespace Cloudhostica.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel? GetBookById(int? Id)
        {
            return DataSource().FirstOrDefault(x => x.Id == Id);
        }
        public List<BookModel> SearchBook(string title, string authorname)
        {
            return DataSource().Where(x=>x.Title==title && x.Equals(authorname)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Nithish"},
                new BookModel(){Id=2,Title="MVC",Author="Sharath"},
                new BookModel(){Id=3,Title=".NET",Author="Jijo"},
                new BookModel(){Id=4,Title="C#",Author="Vikas"},
                new BookModel(){Id=5,Title=".NET MVC Architecture",Author="Prathap"},
                new BookModel(){Id=6,Title="MVC",Author="Bai"}
            };
        }
    }
}
