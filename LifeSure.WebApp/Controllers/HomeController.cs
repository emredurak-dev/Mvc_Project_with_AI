using LifeSure.WebApp.Models;
using LifeSure.WebApp.Models.DataModels;
using LifeSure.WebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LifeSure.WebApp.Controllers
{
    public class HomeController : Controller
    {
        DbLifeSureEntities db = new DbLifeSureEntities();

        public async Task<ActionResult> Index()
        {
            var twitterService = new TwitterService();
            var linkedInService = new LinkedInService();
            
            var twitterUser = await twitterService.GetUserInfo("MurattYucedag");
            var linkedInUser = await linkedInService.GetUserInfo("muratyucedag");
            
            var combinedUser = new CombinedUserViewModel
            {
                TwitterUser = twitterUser,
                LinkedInUser = linkedInUser
            };
            
            return View(combinedUser);
        }

        public PartialViewResult Feature()
        {
            var features = db.Tbl_Feature.ToList();
            return PartialView(features);
        }

        public PartialViewResult Offer()
        {
            var offers = db.Tbl_Offer.ToList();
            return PartialView(offers);
        }

        public PartialViewResult About()
        {
            var about = db.Tbl_About.ToList();
            return PartialView(about);
        }

        public PartialViewResult Service()
        {
            var services = db.Tbl_Service.ToList();
            return PartialView(services);
        }

        public PartialViewResult FAQ()
        {
            var faqs = db.Tbl_FAQ.ToList();
            return PartialView(faqs);
        }

        public PartialViewResult Employee()
        {
            var employees = db.Tbl_Employee.ToList();
            return PartialView(employees);
        }

        public PartialViewResult Testimonial()
        {
            var testimonials = db.Tbl_Testimonial.ToList();
            return PartialView(testimonials);
        }
        public PartialViewResult Contact()
        {
            var contacts = db.Tbl_Contact.ToList();
            return PartialView(contacts);
        }
    }
}