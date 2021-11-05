using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using StaycationMate.Models;
using System.Net;
using StaycationMate.Services;

namespace StaycationMate.Controllers
{
    public class MyTripController : Controller
    {
        private ApplicationDbContext _context;

        public MyTripController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: MyTrip
        public ActionResult Index()
        {
            var currentUserId = User.Identity.GetUserId();

            var myTrips = _context.MyTrips.Where(t => t.UserId == currentUserId).ToList();

            return View(myTrips);
        }

        public ActionResult Reschedule(int? tripId)
        {
            if (tripId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MyTrip myTrip = _context.MyTrips.Find(tripId);
            if (myTrip == null)
            {
                return HttpNotFound();
            }

            return View(myTrip);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reschedule([Bind(Include = "Id,UserId,Destination,TripDate,User_Rating")] MyTrip myTrip)
        {
            var currentUserId = User.Identity.GetUserId();

            // Rescheduling is only possible when there is no such a duplicate trip 
            if (!_context.MyTrips.Any(mt => mt.Destination == myTrip.Destination && mt.TripDate == myTrip.TripDate && mt.UserId == currentUserId))
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _context.Entry(myTrip).State = EntityState.Modified;
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    return View(myTrip);
                }
                catch
                {
                    return RedirectToAction("MyTripDuplicateTrip", "MyTrip");
                }

            }

            return RedirectToAction("MyTripDuplicateTrip", "MyTrip");
        }

        public ActionResult MyTripDuplicateTrip()
        {
            return View();
        }

        public ActionResult Cancel(int? tripId)
        {
            if (tripId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MyTrip myTrip = _context.MyTrips.Find(tripId);
            if (myTrip == null)
            {
                return HttpNotFound();
            }

            return View(myTrip);
        }

        [HttpPost, ActionName("Cancel")]
        [ValidateAntiForgeryToken]
        public ActionResult CancelConfirmed(int tripId)
        {
            // Get the instance of this deleting Object
            MyTrip myTrip = _context.MyTrips.Find(tripId);

            // Get the rating score that's meant to be subtracted from the sumScore, beacause this record is going to be deleted
            var deletingRating = myTrip.User_Rating;

            // Get the sumScore, countTotalRate
            var sumScore = _context.MyTrips.Where(t => t.Destination == myTrip.Destination).Sum(r => r.User_Rating);
            var countTotalRate = _context.MyTrips.Where(t => t.Destination == myTrip.Destination).Count();

            if (sumScore != null && deletingRating != null)
            {
                // Consider if this is the last record in the system
                if (countTotalRate == 1)
                {
                    int averageRating = 0;

                    Attraction forAssignAverageRatingToZero = _context.Attractions.AsNoTracking().Single(d => d.Location_Name == myTrip.Destination);
                    forAssignAverageRatingToZero.Rating = averageRating;

                    // Modify the average rating in the Attraction database
                    _context.Attractions.Attach(forAssignAverageRatingToZero);
                    _context.Entry(forAssignAverageRatingToZero).Property(p => p.Rating).IsModified = true;
                }
                else
                {

                    // Re-calculate the average rating, subtract the deletingRating from sumScore, and subtract one from countTotalRate
                    int averageRating = (int)((sumScore - deletingRating) / (countTotalRate - 1));

                    Attraction forAssignAverageRating = _context.Attractions.AsNoTracking().Single(d => d.Location_Name == myTrip.Destination);
                    forAssignAverageRating.Rating = averageRating;

                    // Modify the average rating in the Attraction database
                    _context.Attractions.Attach(forAssignAverageRating);
                    _context.Entry(forAssignAverageRating).Property(p => p.Rating).IsModified = true;

                }
            }


            // Remove this trip
            _context.MyTrips.Remove(myTrip);

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Rating(int? tripId)
        {
            if (tripId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MyTrip myTrip = _context.MyTrips.Find(tripId);
            if (myTrip == null)
            {
                return HttpNotFound();
            }

            // Get Object of this attraction
            Attraction forDisplayingAverageRating = _context.Attractions.AsNoTracking().Single(d => d.Location_Name == myTrip.Destination);
            // Pass the rating data to the ViewBag and then display it in the UI
            ViewBag.AverageRatingForThisDestination = forDisplayingAverageRating.Rating;

            return View(myTrip);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Rating([Bind(Include = "Id,UserId,Destination,TripDate,User_Rating")] MyTrip myTrip)
        {
            // Sum up all same Destination's score
            var sumScore = _context.MyTrips.Where(t => t.Destination == myTrip.Destination).Sum(r => r.User_Rating);

            // Count total number of the Destination
            var countTotalRate = _context.MyTrips.Where(t => t.Destination == myTrip.Destination).Count();

            if (sumScore != null)
            {
                // Calculate the average rating: sum score / total number of destination(trip)
                int averageRating = (int)(sumScore / countTotalRate);

                // Getting an Object of Attraction based on its Destination, and this is for assigning the new Rating score
                Attraction forAssignAverageRating = _context.Attractions.AsNoTracking().Single(d => d.Location_Name == myTrip.Destination);
                forAssignAverageRating.Rating = averageRating;

                // Modify the average rating in the Attraction database
                _context.Attractions.Attach(forAssignAverageRating);
                _context.Entry(forAssignAverageRating).Property(p => p.Rating).IsModified = true;
            }


            //myTrip.User_Rating = averageRating;


            if (ModelState.IsValid)
            {
                // Modify the user's rating for this trip
                _context.Entry(myTrip).State = EntityState.Modified;




                // Save the database
                _context.SaveChanges();
                return RedirectToAction("Index");

                // ---------- For TESTING purpose, log the result to the User_Rating column ----------
                //_context.MyTrips.Attach(myTrip);
                //_context.Entry(myTrip).Property(p => p.User_Rating).IsModified = true;
                //_context.SaveChanges();
                //return RedirectToAction("Index");
            }


            return View(myTrip);
        }
    }
}