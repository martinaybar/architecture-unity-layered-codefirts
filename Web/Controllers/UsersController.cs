using Business.Interface;
using Entities;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Web.Models;

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

        //GET: Users/id
        public ActionResult Details(int id)
        {
            var user = _userRepository.FindById(id);
            UserVM userVM = Mapper.Map<User, UserVM>(user);
            return View();
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