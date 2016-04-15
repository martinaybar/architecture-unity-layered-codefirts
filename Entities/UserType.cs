using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("UserTypes")]
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection <User> Users { get; set; }

    }
}
