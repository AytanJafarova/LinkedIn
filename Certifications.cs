using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LinkedIn
{
    public class Certifications
    {
        [Key]
        public int certification_id { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public DateTime issue_date { get; set; }
        public DateTime expiration_date { get; set; }
        public int credential_id { get; set; }
        public int user_id { get; set; }
        public Users Users { get; set; }
        public ICollection<Skills> Skills { get; set; }

    }
}
