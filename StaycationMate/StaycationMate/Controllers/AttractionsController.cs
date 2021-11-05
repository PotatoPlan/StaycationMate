using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StaycationMate.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using System.Net;
using System.Text;
using StaycationMate.Services;

namespace StaycationMate.Controllers
{
    public class AttractionsController : Controller
    {
        // Get DbContext reference
        private ApplicationDbContext _context;

        public AttractionsController()
        {
            _context = new ApplicationDbContext();
        }

        // Dispose this instance after using it
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        [AllowAnonymous]
        // GET: Attractions
        public ActionResult Index()
        {
            var attractions = _context.Attractions.ToList();

            // If the user is admin (which has the privilege to update), then show him/her an admin view
            if (User.IsInRole("CanManageAttractions"))
            {
                return View("IndexAdmin", attractions);
            }

            return View("Index", attractions);
        }

        public ActionResult Booking(string bookingLocation, string bookingCity, string bookingStreetAddress, string bookingState, string bookingPostalCode)
        {
            ViewBag.BookingLocation = bookingLocation;
            ViewBag.BookingCity = bookingCity;
            ViewBag.BookingStreetAddress = bookingStreetAddress;
            ViewBag.BookingState = bookingState;
            ViewBag.BookingPostalCode = bookingPostalCode;

            return View();
        }

        public ActionResult Confirm(string confirmedLocation, string confirmedStreetAddress, string confirmedCity, string confirmedState, string confirmedPostalCode, string confirmedDate, MyTrip myTrip)
        {
            // Convert user's select date to DateTime data type in order to be saved in the database
            DateTime dateTimeConfirmedDate = DateTime.ParseExact(confirmedDate, "dd/MM/yyyy", null);

            var currentUserId = User.Identity.GetUserId();

            // A new booking cannot be added when it has IDENTICAL destination, trip date and user id to one existing trip record in the database
            if (!_context.MyTrips.Any(mt => mt.Destination == confirmedLocation && mt.TripDate == dateTimeConfirmedDate && mt.UserId == currentUserId))
            {
                try
                {
                    // Assign values to the model
                    myTrip.UserId = currentUserId;
                    myTrip.Destination = confirmedLocation;
                    myTrip.TripDate = dateTimeConfirmedDate;

                    // Get sumScore and countTotalRate from MyTrips database for this particular Destination (Location_Name)
                    var sumScore = _context.MyTrips.Where(t => t.Destination == myTrip.Destination).Sum(r => r.User_Rating);
                    var countTotalRate = _context.MyTrips.Where(t => t.Destination == myTrip.Destination).Count();

                    if (sumScore != null)
                    {
                        // Add 1 for the countTotalRate because there is one new record, and calculate the averageRating
                        int averageRating = (int)(sumScore / (countTotalRate + 1));

                        Attraction forAssignAverageRating = _context.Attractions.AsNoTracking().Single(d => d.Location_Name == myTrip.Destination);
                        forAssignAverageRating.Rating = averageRating;

                        // Modify the average rating in the Attraction database
                        _context.Attractions.Attach(forAssignAverageRating);
                        _context.Entry(forAssignAverageRating).Property(p => p.Rating).IsModified = true;
                    }

                    // Save it to the database
                    _context.MyTrips.Add(myTrip);

                    _context.SaveChanges();



                    // Handle the Confirmation Email
                    if (ModelState.IsValid)
                    {
                        try
                        {
                            String toEmail = User.Identity.GetUserName();
                            String subject = "Trip details of " + myTrip.Destination + " on " + myTrip.TripDate.Date.ToString("dd/MM/yyyy");
                            String contents = "Visiting " + myTrip.Destination + " on " + myTrip.TripDate.Date.ToString("dd/MM/yyyy") + ", " + "Address: " + confirmedStreetAddress + ", " + confirmedCity + ", " + confirmedState + " " + confirmedPostalCode;

                            EmailSender emailSender = new EmailSender();
                            emailSender.Send(toEmail, subject, contents);

                            ModelState.Clear();
                        }
                        catch
                        {
                            return View();
                        }
                    }

                    return RedirectToAction("ReadOnlyConfirm", "Attractions", new { readConfirmedLocation = confirmedLocation, readConfirmedStreetAddress = confirmedStreetAddress, readConfirmedCity = confirmedCity, readConfirmedState = confirmedState, readConfirmedPostalCode = confirmedPostalCode, readConfiremdDate = confirmedDate });
                }
                catch
                {
                    return RedirectToAction("ReadOnlyDuplicateTrip", "Attractions");
                }
            }

            return RedirectToAction("ReadOnlyDuplicateTrip", "Attractions");
        }

        public ActionResult ReadOnlyDuplicateTrip()
        {
            return View();
        }

        public ActionResult ReadOnlyConfirm(string readConfirmedLocation, string readConfirmedStreetAddress, string readConfirmedCity, string readConfirmedState, string readConfirmedPostalCode, string readConfiremdDate)
        {
            // This ActionResult makes sure that by refreshing the page, there won't be a new trip added to the user's database
            // Displaying these information in the view
            ViewBag.ConfirmedLocation = readConfirmedLocation;
            ViewBag.ConfirmedStreetAddress = readConfirmedStreetAddress;
            ViewBag.ConfirmedCity = readConfirmedCity;
            ViewBag.ConfirmedState = readConfirmedState;
            ViewBag.ConfirmedPostalCode = readConfirmedPostalCode;
            ViewBag.ConfirmedDate = readConfiremdDate;

            return View();
        }

        public ActionResult Update(int? attractionId)
        {
            if (attractionId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Attraction attraction = _context.Attractions.Find(attractionId);
            if (attraction == null)
            {
                return HttpNotFound();
            }

            return View(attraction);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind(Include = "Id,Location_Name,Street_Address,City,State,Postal_Code,Latitude,Longitude,Thumbnail,Alternative_Text,Rating")] Attraction attraction)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(attraction).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attraction);
        }


        [AllowAnonymous]
        public ActionResult Map()
        {
            var locations = _context.Attractions.ToList();

            return View(locations);
        }
    }
}