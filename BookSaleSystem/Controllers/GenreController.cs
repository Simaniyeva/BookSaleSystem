using BookSaleSystem.Models;
using BusinessLogicLayer.Abstract;
using Entity.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSaleSystem.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;
        private readonly IBookService _bookService;

        public GenreController(IBookService bookService, IGenreService genreService)
        {
            _bookService = bookService;
            _genreService = genreService;
        }
        [HttpGet]
        public IActionResult AllGenres()
        {
            BookViewModel model = new BookViewModel();
            model.Genres = _genreService.Get();

            return View(model);
        }

        [HttpGet]
        public IActionResult GetGenre(int id)
        {
            BookViewModel model = new BookViewModel();
            List<Book> books = _bookService.Get();
            model.Books = books.Where(I => I.GenreId == id).ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddGenre()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGenre(Genre genre)
        {
            _genreService.Add(genre);
            return RedirectToAction("AllGenres");
        }
      
      
        [HttpGet]
        public IActionResult DeleteGenre(int id)
        {
           var GenreValue = _genreService.GetById(id);
            _genreService.Delete(GenreValue);
            return RedirectToAction("AllGenres");
        }
    }
}
