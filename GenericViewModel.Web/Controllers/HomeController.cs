using GenericViewModel.Web.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericViewModel.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomeModel()
            {
                SpecificControl1 = new GenericModel<SubModel1>()
                {
                    Name = "SpecificControl1",
                    SubModel = new SubModel1()
                    {
                        Age = 20
                    }
                },
                SpecificControl2 = new GenericModel<SubModel2>()
                {
                    Name = "SpecificControl2",
                    SubModel = new SubModel2()
                    {
                        IsVisible = true
                    }
                }
            });
        }

        [HttpPost]
        public ActionResult Index(HomeModel homeModel)
        {
            return RedirectToAction("Index");
        }
    }
}
