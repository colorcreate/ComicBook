using ComicBook.Data;
using ComicBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBook.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = new ComicBookRepository();
        

        public ActionResult Detail(int? Id)
        {
            if (Id == null)
                return HttpNotFound();

            var SelectedcomicBook = _comicBookRepository.getComicBook((int)Id);
            return View(SelectedcomicBook);
        }

        

        public ActionResult Index()
        {
            var allcomicBook = _comicBookRepository.getAllComicBook();
            return View(allcomicBook);
        }


    }

        
    
}