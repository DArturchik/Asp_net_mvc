using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly string content = String.Format("Trade In: Trade‑in values vary. iPhone 11 and iPhone 11 Pro promotional pricing is after trade‑in of iPhone 8 Plus and iPhone X in good condition. Additional trade‑in values require purchase of a new iPhone, subject to availability and limits. Must be at least 18. Apple or its trade-in partners reserve the right to refuse or limit any Trade In transaction for any reason. In‑store trade‑in requires presentation of a valid, government-issued photo ID (local law may require saving this information). Sales tax may be assessed on full value of new iPhone. Additional terms from Apple or Apple’s trade-in partners may apply. Monthly pricing: Available to qualified customers and requires 0% APR, 24-month installment loan with Citizens One or Apple Card Monthly Installments and iPhone activation with AT&T, Sprint, T-Mobile, or Verizon. Taxes and shipping not included. Additional Apple Card Monthly Installments terms are in the Customer Agreement. Additional iPhone Payments terms are here.");

        public ActionResult Index()
        {
            ViewBag.Title = "Task #1";
            ViewBag.ContentText = content;
            return View();
        }
        public ActionResult ArticlesPage() 
        {
            return View();
        }
        public ActionResult Feedback() 
        {
            return View();
        }
        [HttpPost]
        public ViewResult _Action_FeedBack(string Name,DateTime Date,string Msg) 
        {

            ViewBag._Name = Name;
            ViewBag._Date = Date.ToString("yyyy-MM-dd");
            ViewBag._Msg = Msg;
            
   
            return View("~/Views/Attr/FeedBack_Res.cshtml");
        }

        public ActionResult Questionnaire() 
        {
            
            return View();
        }
        


    }
}