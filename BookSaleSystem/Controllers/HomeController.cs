using BookSaleSystem.Models;
using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concrete;
using DataAccessLayer.Abstract.Repositories;
using DataAccessLayer.Concrete;
using Entity.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookSaleSystem.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        public HomeController(IBookService bookService, IGenreService genreService)
        {
            _bookService = bookService;
            _genreService = genreService;
        }
        public IActionResult Index()
        {
            BookViewModel model = new BookViewModel();
            List<Book> books = _bookService.Get();
            model.Books = books.Where(I => I.Count < 10).ToList();
            return View(model);


        }
        public IActionResult GetAll()
        {
            BookViewModel model = new BookViewModel();
            model.Books = _bookService.Get();
            return View(model);



        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            BookViewModel model = new BookViewModel();
            model.Book = _bookService.GetById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult GetByName(string name)
        {
            BookViewModel model = new BookViewModel();
            List<Book> books = _bookService.Get();
            model.Books = books.Where(I => I.BookName.ToLower().Contains(name.ToLower())).ToList();
            return View(model);

        }
        [HttpGet]
        public IActionResult GetByGenreID(int id)
        {
            BookViewModel model = new BookViewModel();
            List<Book> books = _bookService.Get();
            model.Books = books.Where(I => I.GenreId == id).ToList();
            return View(model);
        }
        
        public IActionResult AdminOperations()
        {
            BookViewModel model = new BookViewModel();
            model.Books = _bookService.Get();

            return View(model);
        
        }
      
       [HttpGet]
       public IActionResult AddBook()
        {
            return View();

        }
        [HttpPost]
         public IActionResult AddBook(Book book)
        {
            _bookService.Add(book);
            return RedirectToAction("GetAll", "Home");
        }
    
        [HttpGet]

        public IActionResult DeleteBook(int id)
        {
            BookViewModel model = new BookViewModel();
            model.Book = _bookService.GetById(id);
            return View(model);

        }
        [HttpPost]
        public IActionResult DeleteBook(Book book)
        {
            _bookService.Delete(book);

            return RedirectToAction("GetAll", "Home");
        }
        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            BookViewModel model = new BookViewModel();
            model.Book = _bookService.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateBook(Book book)
        {  
           
            if (ModelState.IsValid)
            {
                _bookService.Update(book);
                return RedirectToAction("GetAll", "Home");


            } BookViewModel model = new BookViewModel();

            model.Book = book;
          
            return View(model);

     


        }
    }
}
