using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Comments
    {
        [Key]
        public int comment_id { get; set; }
        public string content { get; set; }
        public DateTime comment_date { get; set; }
        public int user_id { get; set; }
        public Users Users { get; set; }
        public int post_id { get; set; }
        public Posts Posts { get; set; }


    }
}
