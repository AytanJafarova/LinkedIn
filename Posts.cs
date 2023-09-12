using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Posts
    {
        [Key]
        public int post_id { get; set; }
        public string post_content { get; set; }
        public DateTime posting_date { get; set; }
        public string background { get; set; }
        public int user_id { get; set; }
        public Users Users { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Reactions> Reactions { get; set; }


    }
}
