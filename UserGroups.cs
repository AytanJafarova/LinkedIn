using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class UserGroups
    {
        [Key]
        public int relation_id { get; set; }
        public int user_id { get; set; }
        public Users Users { get; set; }
        public int group_id { get; set; }
        public Groups Groups { get; set; }

    }
}
