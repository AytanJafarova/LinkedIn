using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Skills
    {
        [Key]
        public int skill_id { get; set; }
        public string skill_name { get; set; }
        public int user_id { get; set; }
        public Users Users { get; set; }
        public int certification_id { get; set; }
        public Certifications Certifications { get; set; }

    }
}
