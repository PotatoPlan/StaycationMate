using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StaycationMate.Models;
using StaycationMate.Services;
using System.IO;


namespace StaycationMate.Controllers
{
    public class BulkEmailController : Controller
    {
        // Get DbContext reference
        private ApplicationDbContext _context;

        public BulkEmailController()
        {
            _context = new ApplicationDbContext();
        }

        // Dispose this instance after using it
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: BulkEmail
        public ActionResult Index()
        {


            if (User.IsInRole("CanManageAttractions"))
            {
                // Get all user's information from database
                var allUsers = _context.Users.ToArray();
                // Count how many users are there in the database (this number will be displayed on the UI)
                var numberOfUsers = _context.Users.Count();
                ViewBag.CountUsers = numberOfUsers;

                // Initialise an empty List
                var listOfUserEmail = new List<string>();

                // Traverse all users in the allUser, which is from the databse, get their email, and add to the List of listOfUserEmail
                foreach (var user in allUsers)
                {
                    listOfUserEmail.Add(user.Email);
                }

                return View(new BulkEmailViewModel());
            }
            return View("Restricted");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Index(BulkEmailViewModel bulkEmailViewModel, HttpPostedFileBase postedFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Get number of users
                    // Since this Index page will be refreshed if the user has not properly upload a file, it means the previous ViewBag's data will be lost
                    // So here we will retrieve the number of users count again from database, and pass it to the View again
                    var numberOfUsers = _context.Users.Count();
                    ViewBag.CountUsersAfterSent = numberOfUsers;


                    // If the file is NOT null, means we have got it, next is to save it into the folder in the server
                    if (postedFile != null && postedFile.ContentLength > 0)
                    {
                        string fileName = Path.GetFileName(postedFile.FileName);
                        string path = Path.Combine(Server.MapPath("~/UploadedFiles"), fileName);
                        postedFile.SaveAs(path);
                    }
                    ViewBag.UploadMessage = "File Uploaded Successfully";

                    // SendGrid will only accept Base64 string of the file, so these steps are called to convert it into a Base64 string
                    byte[] bytesFileData = new byte[postedFile.ContentLength];
                    using (BinaryReader reader = new BinaryReader(postedFile.InputStream))
                    {
                        bytesFileData = reader.ReadBytes(postedFile.ContentLength);
                    }
                    string stringFileData = Convert.ToBase64String(bytesFileData);


                    // Get ALL emails
                    var allUsers = _context.Users.ToArray();
                    var listOfUserEmail = new List<string>();
                    foreach (var user in allUsers)
                    {
                        listOfUserEmail.Add(user.Email);
                    }

                    List<String> allUserEmails = listOfUserEmail;
                    String subject = bulkEmailViewModel.Subject;
                    String contents = bulkEmailViewModel.Contents;

                    // Call the EmailSender and its SendBulk() method
                    EmailSender emailSender = new EmailSender();
                    emailSender.SendBulk(allUserEmails, subject, contents, stringFileData);

                    ModelState.Clear();
                }
                catch
                {
                    ViewBag.UploadMessage = "Failed to upload the file";
                    return View();
                }
            }


            return RedirectToAction("ReadOnlySentConfirm", "BulkEmail");
        }


        public ActionResult ReadOnlySentConfirm()
        {
            return View();
        }
    }
}