using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Users
    {
        [Key]
        public int user_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string? middle_name { get; set; }
        public string location { get; set; }
        public Accounts Accounts { get; set; }
        public ICollection<Connections> Connections { get; set; }
        public ICollection<Educations> Educations { get; set; }
        public ICollection<Experiences> Experiences { get; set; }
        public ICollection<Skills> Skills { get; set; }
        public ICollection<Certifications> Certifications { get; set; }
        public ICollection<Posts> Posts { get; set; }
        public ICollection<Reactions> Reactions { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<UserGroups> UserGroups { get; set; }
    }
}
