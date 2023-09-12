using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Groups
    {
        [Key]
        public int group_id { get; set; }
        public string group_name { get; set; }
        public string description { get; set; }
        public DateTime creation_date { get; set; }
        public ICollection<UserGroups> UserGroups { get; set; }

    }
}
