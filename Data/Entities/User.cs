using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }

        [ForeignKey("UserTypeId")]
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
