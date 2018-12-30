using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            //    return View(movie);

            var customers = new List<Customer>
            {
                new Customer {Name ="Megan Byers" },
                new Customer { Name = "Quinn Brady"},
                new Customer { Name = "Tyler McIntyre"}

            };


            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            //return View(movie);            //return View(movie);

        }

            [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
            public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }  

        public ActionResult About()
        {
            return View("About");
        }
        


        //public ActionResult Edit(int id)
        //{
        //    return Content("id =" + id);
        //}

        // movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}