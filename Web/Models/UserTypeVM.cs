using System.Collections.Generic;


namespace Web.Models
{
    public class UserTypeVM
    {
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserVM> Users { get; set; }

    }
}