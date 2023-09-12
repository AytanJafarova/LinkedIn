using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Experiences
    {
        [Key]
        public int experience_id { get; set; }
        public string company_name { get; set; }
        public string position { get; set; }
        public string employee_type { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int user_id { get; set; }
        public Users Users { get; set; }

    }
}
