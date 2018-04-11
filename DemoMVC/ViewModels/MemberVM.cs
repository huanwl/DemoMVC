using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.ViewModels
{
    public class MemberVM
    {
        [Required]
        public string UserName { get; set; }

        [Required, RegularExpression("[A-Za-z0-9]{6,20}", ErrorMessage = "Error Format")]
        public string Password { get; set; }

        [Required]
        public string NickName { get; set; }

        [Required, RegularExpression("[0-9]+", ErrorMessage = "Error Format")]
        public string Phone { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}