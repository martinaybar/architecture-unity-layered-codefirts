using System;
using System.Data.Spatial;


namespace Diagrams
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } //TODO Encrypt and Decrypt from Common        
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[] RowVersion { get; set; }
        public DbGeography Location { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }
    }
}