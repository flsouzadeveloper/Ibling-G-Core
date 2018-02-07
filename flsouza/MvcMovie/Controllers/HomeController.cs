using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EnviarEmail(string name, string email, string subject, string message ){
            string n = name;
            string e = email;
            string s = subject;
            string m = message;


             return View("Index");
        }

        // private void SendMail(string mailbody)
        // {
        //     using (var message = new MailMessage(Contact.Email, "me@mydomain.com"))
        //     {
        //         message.To.Add(new MailAddress("me@mydomain.com"));
        //         message.From = new MailAddress(Contact.Email);
        //         message.Subject = "New E-Mail from my website";
        //         message.Body = mailbody;

        //         using (var smtpClient = new SmtpClient("mail.mydomain.com"))
        //         {
        //         smtpClient.Send(message);
        //         }
        //     }
        // }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
