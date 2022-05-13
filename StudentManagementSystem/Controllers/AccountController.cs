using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class AccountController : Controller
    {

        StudentManagementSystemEntities1 StudentManagementSystemEntity = new StudentManagementSystemEntities1();
        
        // GET: Account

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            StudentManagementSystemEntity.Users.Where(u=>u.username == user.username && u.password == user.password);
            return View();
        }

    }
}