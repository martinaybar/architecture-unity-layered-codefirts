using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Interface;

using Data.Entities;

namespace Web.Controllers
{

    public class UsersController : Controller
    {
        private IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }


        // GET: Users
        public ActionResult Index()
        {
            IEnumerable<User> users = _userRepository.GetAll();
            return View(users);
        }
    }
}