using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserPortalWebService.Models;

namespace UserPortalWebService.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private MainDataContext db = new MainDataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {


            return View();
        }

        public ActionResult UserList()
        {
            return View(db.Users.ToList());
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Admin admin, string button)
        {


            if (button == "Clear")
            {

                ModelState.Clear();
                return View();

            }


            using (MainDataContext db = new MainDataContext())
            {

                var userExist = db.Admin.Where(a => a.Email.Equals(admin.Email) && a.Password.Equals(admin.Password)).FirstOrDefault();

                if (userExist != null)
                {

                    return RedirectToAction("UserList");

                }

            }



            return View();
        }




    }
}