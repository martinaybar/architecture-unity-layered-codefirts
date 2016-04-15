using Business.Interface;
using Entities;
using System.Collections.Generic;
using System.Web.Mvc;

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