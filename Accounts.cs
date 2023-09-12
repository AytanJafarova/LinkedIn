using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn
{
    public class Accounts
    {
        [Key]
        public int account_id { get; set; }
        public string headline { get; set; }
        public string summary { get; set; }
        public string job_industry { get; set; }

        public int user_id { get; set; }
        public Users Users { get; set; }
    }
}
