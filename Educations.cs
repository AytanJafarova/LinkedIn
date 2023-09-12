using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Educations
    {
        [Key]
        public int education_id { get; set; }
        public string school_name { get; set; }
        public string degree { get; set; }
        public string field { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int user_id { get; set; }
        public Users Users { get; set; }

    }
}
