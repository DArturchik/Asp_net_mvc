using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication2.Controllers
{
    public class AttrController : Controller
    {
        public ActionResult FeedBack_Res() 
        {
            return View();
        }
        [HttpPost]
        public ViewResult Questionnaire_Res(string FName, string LName, string Male, string Female,string Bachelor, string Master)
        {

            ViewBag._FName = FName;
            ViewBag._LName = LName;

            if (Male=="true") 
            {
                ViewBag._Male = Male;
                if (Female == "true") 
                {
                    ViewBag._Female = "";

                }
                
            }
            if (Female == "true")
            {
                ViewBag._Female = Female;
                if (Male == "true")
                {
                    ViewBag._Male = "";

                }


            }

            if (Bachelor == "true")
            {
                ViewBag._Bachelor = Bachelor;
                if (Master == "true")
                {
                    ViewBag._Master = "";
                }
            }
            if (Master == "true")
            {
                ViewBag._Master = Master;
                if (Bachelor == "true")
                {
                    ViewBag._Bachelor = "";
                }
            }






            return View("~/Views/Attr/Questionnaire_Res.cshtml");
        }
        

    }
}