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
                new BookModel(){Id=1,Title="MVC",Author="Nithish",Description="This is the description of MVC"},
                new BookModel(){Id=2,Title="MVC",Author="Sharath",Description="This is the description of MVC"},
                new BookModel(){Id=3,Title=".NET",Author="Jijo",Description="This is the description of .NET"},
                new BookModel(){Id=4,Title="C#",Author="Vikas",Description="This is the description of C#"},
                new BookModel(){Id=5,Title=".NET MVC Architecture",Author="Prathap",Description="This is the description of .NET MVC Architecture"},
                new BookModel(){Id=6,Title="MVC",Author="Bai", Description = "This is the description of MVC"},
                new BookModel(){Id=7,Title="Azure",Author="Bai", Description = "This is the description of MVC"},
                new BookModel(){Id=8,Title="Azure Devops",Author="aaa", Description = "This is the description of MVC"},
                new BookModel(){Id=9,Title="C++",Author="aaa", Description = "This is the description of MVC"},
                new BookModel(){Id=10,Title="Java",Author="Baaai", Description = "This is the description of MVC"}
            };
        }
    }
}
