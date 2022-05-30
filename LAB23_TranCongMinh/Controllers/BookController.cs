using LAB23_TranCongMinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB23_TranCongMinh.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("TRUYEN KIEU-TO HOAI");
            books.Add("DE MEN PHIEU LUU KY-TO HOAI");
            books.Add("QUE NGUOI-TO HOAI");
            ViewBag.Books = books;
            return View();
        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "TRUYEN KIEU", "TO HOAI", "/Content/image/TRUYENKIEU.jpg"));
            books.Add(new Book(1, "DE MEN PHIEU LUU KY", "TO HOAI", "/Content/image/DMPLK.jpg"));
            books.Add(new Book(1, "QUE NGUOI", "TO HOAI", "/Content/image/QUENGUOI.jpg"));
            return View(books);

        }
        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "TRUYEN KIEU", "TO HOAI", "/Content/image/TRUYENKIEU.jpg"));
            books.Add(new Book(1, "DE MEN PHIEU LUU KY", "TO HOAI", "/Content/image/DMPLK.jpg"));
            books.Add(new Book(1, "QUE NGUOI", "TO HOAI", "/Content/image/QUENGUOI.jpg"));
            Book book = new Book();
            foreach (Book b in books)
            {
                if(b.Id==id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

    }
}