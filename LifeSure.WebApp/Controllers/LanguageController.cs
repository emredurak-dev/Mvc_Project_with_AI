using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LifeSure.WebApp.Controllers
{
    public class LanguageController : Controller
    {
        public ActionResult Change(string lang, string returnUrl)
        {
            if (!string.IsNullOrEmpty(lang))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);

                HttpCookie cookie = new HttpCookie("lang", lang);
                cookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cookie);
            }
            return Redirect(returnUrl ?? "/");
        }
    }
} 