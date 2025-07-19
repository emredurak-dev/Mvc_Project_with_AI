using LifeSure.WebApp.Models.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Linq;

namespace LifeSure.WebApp.Controllers
{
    public class AdminController : Controller
    {
        DbLifeSureEntities db = new DbLifeSureEntities();
        public ActionResult Dashboard()
        {
            return View();
        }

        //feature
        public ActionResult Feature()
        {
            var features = db.Tbl_Feature.ToList();
            return View(features);
        }

        [HttpGet]
        public ActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFeature(Tbl_Feature feature)
        {
            db.Tbl_Feature.Add(feature);
            db.SaveChanges();
            return RedirectToAction("Feature");
        }

        public ActionResult DeleteFeature(int id)
        {
            var feature = db.Tbl_Feature.Find(id);
            db.Tbl_Feature.Remove(feature);
            db.SaveChanges();
            return RedirectToAction("Feature");
        }

        [HttpGet]
        public ActionResult EditFeature(int id)
        {
            var feature = db.Tbl_Feature.Find(id);
            return View(feature);
        }

        [HttpPost]
        public ActionResult EditFeature(Tbl_Feature feature)
        {
            var existingFeature = db.Tbl_Feature.Find(feature.FeatureId);
            existingFeature.Title = feature.Title;
            existingFeature.Description = feature.Description;
            existingFeature.VideoURL = feature.VideoURL;
            existingFeature.ImageURL = feature.ImageURL;
            existingFeature.Link = feature.Link;
            db.SaveChanges();
            return RedirectToAction("Feature");
        }

        //offer
        public ActionResult Offer()
        {
            var offers = db.Tbl_Offer.ToList();
            return View(offers);
        }

        [HttpGet]
        public ActionResult AddOffer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOffer(Tbl_Offer offer)
        {
            db.Tbl_Offer.Add(offer);
            db.SaveChanges();
            return RedirectToAction("Offer");
        }

        public ActionResult DeleteOffer(int id)
        {
            var offer = db.Tbl_Offer.Find(id);
            db.Tbl_Offer.Remove(offer);
            db.SaveChanges();
            return RedirectToAction("Offer");
        }

        [HttpGet]
        public ActionResult EditOffer(int id)
        {
            var offer = db.Tbl_Offer.Find(id);
            return View(offer);
        }

        [HttpPost]
        public ActionResult EditOffer(Tbl_Offer offer)
        {
            var existingOffer = db.Tbl_Offer.Find(offer.OfferId);
            existingOffer.Title = offer.Title;
            existingOffer.Description = offer.Description;
            existingOffer.Icon = offer.Icon;
            existingOffer.Link = offer.Link;
            db.SaveChanges();
            return RedirectToAction("Offer");
        }

        //about
        public ActionResult About()
        {
            var about = db.Tbl_About.ToList();
            return View(about);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(Tbl_About about)
        {
            db.Tbl_About.Add(about);
            db.SaveChanges();
            return RedirectToAction("About");
        }

        public ActionResult DeleteAbout(int id)
        {
            var about = db.Tbl_About.Find(id);
            db.Tbl_About.Remove(about);
            db.SaveChanges();
            return RedirectToAction("About");
        }

        [HttpGet]
        public ActionResult EditAbout(int id)
        {
            var about = db.Tbl_About.Find(id);
            return View(about);
        }

        [HttpPost]
        public ActionResult EditAbout(Tbl_About about)
        {
            var existingAbout = db.Tbl_About.Find(about.AboutId);
            existingAbout.Title = about.Title;
            existingAbout.Description = about.Description;
            existingAbout.ImageURL = about.ImageURL;
            db.SaveChanges();
            return RedirectToAction("About");
        }

        //service
        public ActionResult Service()
        {
            var services = db.Tbl_Service.ToList();
            return View(services);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(Tbl_Service service)
        {
            try
            {
                db.Tbl_Service.Add(service);
                db.SaveChanges();
                return RedirectToAction("Service");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.PropertyName + ": " + x.ErrorMessage)
                    .ToList();
                ViewBag.ValidationErrors = errorMessages;
                return View(service);
            }
        }

        public ActionResult DeleteService(int id)
        {
            var service = db.Tbl_Service.Find(id);
            db.Tbl_Service.Remove(service);
            db.SaveChanges();
            return RedirectToAction("Service");
        }

        [HttpGet]
        public ActionResult EditService(int id)
        {
            var service = db.Tbl_Service.Find(id);
            return View(service);
        }

        [HttpPost]
        public ActionResult EditService(Tbl_Service service)
        {
            var existingService = db.Tbl_Service.Find(service.ServiceId);
            existingService.Title = service.Title;
            existingService.Description = service.Description;
            existingService.ImageURL = service.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Service");
        }

        //faq
        public ActionResult Faq()
        {
            var faqs = db.Tbl_FAQ.ToList();
            return View(faqs);
        }

        [HttpGet]
        public ActionResult AddFaq()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFaq(Tbl_FAQ faq)
        {
            db.Tbl_FAQ.Add(faq);
            db.SaveChanges();
            return RedirectToAction("Faq");
        }

        public ActionResult DeleteFaq(int id)
        {
            var faq = db.Tbl_FAQ.Find(id);
            db.Tbl_FAQ.Remove(faq);
            db.SaveChanges();
            return RedirectToAction("Faq");
        }

        [HttpGet]
        public ActionResult EditFaq(int id)
        {
            var faq = db.Tbl_FAQ.Find(id);
            return View(faq);
        }

        [HttpPost]
        public ActionResult EditFaq(Tbl_FAQ faq)
        {
            var existingFaq = db.Tbl_FAQ.Find(faq.FAQId);
            existingFaq.Question = faq.Question;
            existingFaq.Answer = faq.Answer;
            db.SaveChanges();
            return RedirectToAction("Faq");
        }

        //employee
        public ActionResult Employee()
        {
            var employees = db.Tbl_Employee.ToList();
            return View(employees);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Tbl_Employee employee)
        {
            db.Tbl_Employee.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Employee");
        }

        public ActionResult DeleteEmployee(int id)
        {
            var employee = db.Tbl_Employee.Find(id);
            db.Tbl_Employee.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Employee");
        }

        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            var employee = db.Tbl_Employee.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult EditEmployee(Tbl_Employee employee)
        {
            var existingEmployee = db.Tbl_Employee.Find(employee.EmployeeId);
            existingEmployee.Name = employee.Name;
            existingEmployee.Surname = employee.Surname;
            existingEmployee.Title = employee.Title;
            existingEmployee.ImageURL = employee.ImageURL;
            existingEmployee.Facebook = employee.Facebook;
            existingEmployee.X = employee.X;
            existingEmployee.LinkedIn = employee.LinkedIn;
            existingEmployee.Instagram = employee.Instagram;
            db.SaveChanges();
            return RedirectToAction("Employee");
        }

        //testimonial
        public ActionResult Testimonial()
        {
            var testimonials = db.Tbl_Testimonial.ToList();
            return View(testimonials);
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimonial(Tbl_Testimonial testimonial)
        {
            db.Tbl_Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Testimonial");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var testimonial = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(testimonial);
            db.SaveChanges();
            return RedirectToAction("Testimonial");
        }

        [HttpGet]
        public ActionResult EditTestimonial(int id)
        {
            var testimonial = db.Tbl_Testimonial.Find(id);
            return View(testimonial);
        }

        [HttpPost]
        public ActionResult EditTestimonial(Tbl_Testimonial testimonial)
        {
            var existingTestimonial = db.Tbl_Testimonial.Find(testimonial.TestimonialId);
            existingTestimonial.Name = testimonial.Name;
            existingTestimonial.Surname = testimonial.Surname;
            existingTestimonial.Title = testimonial.Title;
            existingTestimonial.Comment = testimonial.Comment;
            existingTestimonial.ImageURL = testimonial.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Testimonial");
        }

        //contact
        public ActionResult Contact()
        {
            var contacts = db.Tbl_Contact.ToList();
            return View(contacts);
        }

        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Tbl_Contact contact)
        {
            db.Tbl_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Contact");
        }

        public ActionResult DeleteContact(int id)
        {
            var contact = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(contact);
            db.SaveChanges();
            return RedirectToAction("Contact");
        }

        [HttpGet]
        public ActionResult EditContact(int id)
        {
            var contact = db.Tbl_Contact.Find(id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult EditContact(Tbl_Contact contact)
        {
            var existingContact = db.Tbl_Contact.Find(contact.ContactId);
            existingContact.Address = contact.Address;
            existingContact.Email = contact.Email;
            existingContact.Phone = contact.Phone;
            db.SaveChanges();
            return RedirectToAction("Contact");
        }

        [HttpPost]
        public async Task<JsonResult> GenerateImage(string prompt)
        {
            string apiKey = "YOUR-HUGGING-FACE-API-KEY";
            string apiUrl = "https://api-inference.huggingface.co/models/black-forest-labs/FLUX.1-dev";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                var content = new StringContent("{\"inputs\": \"" + prompt.Replace("\"", "\\\"") + "\"}", Encoding.UTF8, "application/json");
                var response = await client.PostAsync(apiUrl, content);
                var json = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var answer = ExtractGeminiAnswer(json);
                    return Json(new { answer, raw = json }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { answer = "", raw = json }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public async Task<JsonResult> GenerateChatGPTFAQs(string prompt)
        {
            string apiKey = "YOUR-RAPIDAPI-KEY";
            string apiUrl = "https://chatgpt-42.p.rapidapi.com/chatgpt";
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(apiUrl),
                };
                request.Headers.Add("x-rapidapi-key", apiKey);
                request.Headers.Add("x-rapidapi-host", "chatgpt-42.p.rapidapi.com");
                
                // Daha spesifik prompt oluştur
                var enhancedPrompt = $"Create exactly 3 FAQs about {prompt}. Format each FAQ as follows:\n\n1. Q: [Question]\nA: [Answer]\n\n2. Q: [Question]\nA: [Answer]\n\n3. Q: [Question]\nA: [Answer]";
                
                // Yeni format: messages array kullan
                var requestBody = "{\"messages\":[{\"role\":\"user\",\"content\":\"" + enhancedPrompt.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n") + "\"}],\"web_access\":false}";
                var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Content = content;

                var response = await client.SendAsync(request);
                var json = await response.Content.ReadAsStringAsync();
                
                // Debug için JSON'u dosyaya yaz
                System.IO.File.WriteAllText(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/chatgpt_response.json"), json);
                
                if (response.IsSuccessStatusCode)
                {
                    var faqs = ExtractChatGPTFAQs(json);
                    return Json(new { faqs, raw = json }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { faqs = new List<object>(), raw = json }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        private List<object> ExtractChatGPTFAQs(string json)
        {
            try
            {
                var obj = JObject.Parse(json);
                
                var response = obj["response"]?.ToString() ?? 
                              obj["message"]?.ToString() ?? 
                              obj["content"]?.ToString() ?? 
                              obj["text"]?.ToString() ?? 
                              obj["result"]?.ToString();
                
                if (string.IsNullOrEmpty(response))
                {
                    System.IO.File.WriteAllText(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/chatgpt_parsed.txt"), "Response is null or empty. Full JSON: " + json);
                    return new List<object>();
                }

                var faqs = new List<object>();
                
                var lines = response.Split('\n');
                var currentQuestion = "";
                var currentAnswer = "";
                var questionNumber = 0;
                
                foreach (var line in lines)
                {
                    var trimmedLine = line.Trim();
                    
                    if (trimmedLine.StartsWith("Q:") || 
                        trimmedLine.StartsWith("Question:") || 
                        trimmedLine.StartsWith("1.") || 
                        trimmedLine.StartsWith("2.") || 
                        trimmedLine.StartsWith("3.") ||
                        (trimmedLine.Length > 0 && char.IsDigit(trimmedLine[0]) && trimmedLine.Contains(".")))
                    {
                        if (!string.IsNullOrEmpty(currentQuestion) && !string.IsNullOrEmpty(currentAnswer))
                        {
                            faqs.Add(new { question = currentQuestion, answer = currentAnswer });
                            questionNumber++;
                        }
                        
                        currentQuestion = trimmedLine
                            .Replace("Q:", "").Replace("Question:", "")
                            .Replace("1.", "").Replace("2.", "").Replace("3.", "")
                            .Trim();
                        
                        if (currentQuestion.Length <= 2 && char.IsDigit(currentQuestion[0]))
                        {
                            currentQuestion = "";
                        }
                        
                        currentAnswer = "";
                    }
                    else if (trimmedLine.StartsWith("A:") || trimmedLine.StartsWith("Answer:"))
                    {
                        currentAnswer = trimmedLine.Replace("A:", "").Replace("Answer:", "").Trim();
                    }
                    else if (!string.IsNullOrEmpty(currentAnswer) && !string.IsNullOrEmpty(trimmedLine))
                    {
                        currentAnswer += " " + trimmedLine;
                    }
                    else if (!string.IsNullOrEmpty(currentQuestion) && string.IsNullOrEmpty(currentAnswer) && !string.IsNullOrEmpty(trimmedLine))
                    {
                        currentAnswer = trimmedLine;
                    }
                }
                
                if (!string.IsNullOrEmpty(currentQuestion) && !string.IsNullOrEmpty(currentAnswer))
                {
                    faqs.Add(new { question = currentQuestion, answer = currentAnswer });
                }
                
                if (faqs.Count == 0)
                {
                    var parts = response.Split(new[] { "Q:", "Question:", "1.", "2.", "3." }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < Math.Min(parts.Length, 3); i++)
                    {
                        var part = parts[i].Trim();
                        var qaSplit = part.Split(new[] { "A:", "Answer:" }, StringSplitOptions.None);
                        if (qaSplit.Length >= 2)
                        {
                            faqs.Add(new { 
                                question = qaSplit[0].Trim(), 
                                answer = qaSplit[1].Trim() 
                            });
                        }
                    }
                }
                
                while (faqs.Count < 3)
                {
                    faqs.Add(new { 
                        question = "Sample Question " + (faqs.Count + 1), 
                        answer = "Sample Answer " + (faqs.Count + 1) 
                    });
                }
                
                return faqs.Take(3).ToList();
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/chatgpt_error.txt"), "Error: " + ex.Message + "\nJSON: " + json);
                return new List<object>
                {
                    new { question = "What is this service?", answer = "This is a sample FAQ answer." },
                    new { question = "How can I get help?", answer = "You can contact our support team." },
                    new { question = "What are your business hours?", answer = "We are available 24/7." }
                };
            }
        }
    }
}