using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        
        public virtual UserType UserType { get; set; }


        #region Constructor

        public User(string firstName, string lastName, int userTypeId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserTypeId = userTypeId;
        }

        public User()
        {

        }
        #endregion
    }
}
