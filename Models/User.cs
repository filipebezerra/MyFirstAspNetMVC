using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstAspNetMVC.Models
{
    public class User
    {
        public string loginName { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public DateTime dataLogin { get; set; }
        public bool receberInfo { get; set; }
    }
}