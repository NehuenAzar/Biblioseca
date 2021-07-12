using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioseca.Model;
using NHibernate;
using NHibernate.Cfg;

namespace Biblioseca.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISessionFactory sessionFactory = new Configuration()
                .Configure()
                .BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();


            Book book = new Book();
            book.Title = "Operación Masacre";
            book.AuthorId = 1;
            book.Category = "Novela No Ficción";
            book.ISBN = "978 - 950 - 515 - 352 - 7";
            book.Description = "Historia de los fusilamientos clandestinos de 1956";

            session.Save(book);

            Console.WriteLine(book.Id);
            Console.ReadKey();

        }
    }
}
