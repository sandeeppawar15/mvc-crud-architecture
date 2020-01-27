using mvc_crud.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_crud.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }



        // GET: User
        public ActionResult Index()
        {
            var users = _userService.Get();
            return View(users);
        }
    }
}