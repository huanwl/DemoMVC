using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Member
    {  
        [Key]
        public string UserName { get; set; }

        public string Password { get; set; }

        public string NickName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}