using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Core.Models;
using MuaBan.Models;
using System.Net.Mail;
using System.Net;

namespace MuaBan.Controllers
{
    public class ContactController : SurfaceController
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        private const String Patial_Path = "~/Views/Partials/Contact/";

        public ActionResult RenderSectionContact()
        {
            return PartialView(string.Format("{0}SectionContact.cshtml", Patial_Path));
        }
        public ActionResult HandleSubmitForm(Contact model)
        {
            if (ModelState.IsValid)
            { 
            var message = Services.ContentService.CreateContent( String.Format("{0}-{1}",model.Name,DateTime.Now.ToString()), CurrentPage.Id, "Contact");
            message.SetValue("UserName", model.Name);
            message.SetValue("Email", model.Email);
            message.SetValue("Phone", model.Phone);
            message.SetValue("Title", model.Title);
            message.SetValue("Messeage", model.Messeage);
            Services.ContentService.SaveAndPublishWithStatus(message);
            SendMail(model);
           // return RedirectToCurrentUmbracoPage();
                return View("Contact");
            }
            //return CurrentUmbracoPage();
               return View("Contact");
        }
        private void SendMail(Contact model)
        {
            var frommail = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["SendEmailFrom"]);
            var Pass = System.Configuration.ConfigurationManager.AppSettings["EmailPass"];
            var tomail = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["SendEmailTo"]);
            string Title = model.Title + " - Mua Bán Máy Tính";
            string Message = "Email khách hàng: " + model.Email + " \nTên khách hàng: " +model.Name+ " \nSố điện thoại: " + model.Phone + "\nNội dung: " + model.Messeage;
            var smtp = new System.Net.Mail.SmtpClient()
            {
                Host="smtp.gmail.com",
                Port=587,
                EnableSsl=true,
                DeliveryMethod=SmtpDeliveryMethod.Network,
                UseDefaultCredentials=false,
                Credentials =new NetworkCredential(frommail.Address, Pass)

            };
            var mess = new MailMessage(frommail, tomail)
            {
                Subject = Title,
                Body=Message,
            };
            smtp.Send(mess);
        }
    }
}