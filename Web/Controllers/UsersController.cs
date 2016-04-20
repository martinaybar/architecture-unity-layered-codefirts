using Business.Interface;
using Entities;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Web.Models;
using log4net;


namespace Web.Controllers
{
    public class UsersController : Controller
    {
        private IUserRepository _userRepository;
        private static readonly ILog log = LogManager.GetLogger(typeof(HomeController));


        public UsersController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

            
        // GET: Users
        public ActionResult Index()
        {
            log.Info("GetAllUsers");

            IEnumerable<User> users = _userRepository.GetAll();
            return View(users);
        }

        //GET: Users/id
        public ActionResult Details(int id)
        {
            var user = _userRepository.FindById(id);
            return View(user);
        }


        /// <summary>
        /// Dispose repository.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                this._userRepository.Dispose();

            base.Dispose(disposing);
        }

    }
}