using System;
using System.Web.Http;
using Vidly.Dtos;
using System.Linq;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //if (newRental.MoviesIds.Count == 0)
            //    return BadRequest("No Movies Ids have been given.");

            //var customer = _context.Customers.SingleOrDefault(
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            //if (customer == null)
            //    return BadRequest("Customer Id is not valid.");

            var movies = _context.Movies.Where(
                m => newRental.MoviesIds.Contains(m.Id)).ToList();

            //if (movies.Count != newRental.MoviesIds.Count)
            //    return BadRequest("One or more MoviesIds are invalid.");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}