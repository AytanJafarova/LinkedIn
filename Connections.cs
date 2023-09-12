using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Connections
    {
        [Key]
        public int connection_id { get; set; }
        public string status { get; set; }
        public int connected_user_id { get; set; }
        public int user_id { get; set; }
        public Users Users { get; set; }


    }
}
