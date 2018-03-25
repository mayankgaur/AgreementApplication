using AgreementApplication.Models;
using AgreementApplication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgreementApplication.Controllers
{
    public class HomeController : Controller
    {
        private AgreementService objAgree;
        public HomeController()
        {
            this.objAgree = new AgreementService();
        }

        public ActionResult Index()
        {
            return View(objAgree.GetAll());
        }

        public ActionResult Edit(int Id)
        {

            return View(objAgree.GetbyID(Id));
        }

         [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(AgreementDetail model)
        {
            
            if (ModelState.IsValid)
            {
               
                objAgree.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

         public ActionResult Create()
         {
             return View();
         }

        [HttpPost]
         public ActionResult Create(AgreementDetail model)
        {           
            if (ModelState.IsValid)
            {

                objAgree.Insert(model);
                return RedirectToAction("Index");
            }
            return View(model);           
        }

      
    }
}
