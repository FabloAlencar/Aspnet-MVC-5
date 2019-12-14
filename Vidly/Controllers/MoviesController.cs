﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public ActionResult Save(Movie Movie)
        {
            if (Movie.Id == 0)
            {
                _context.Movies.Add(Movie);
            }
            else
            {
                var MovieinDb = _context.Movies.Single(c => c.Id == Movie.Id);
                MovieinDb.Name = Movie.Name;
                MovieinDb.ReleaseDate = Movie.ReleaseDate;
                MovieinDb.GenreId = Movie.GenreId;
                MovieinDb.NumberInStock = Movie.NumberInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var Movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (Movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = Movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("NewMovie", viewModel);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            movie.AddedDate = DateTime.Now;
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}