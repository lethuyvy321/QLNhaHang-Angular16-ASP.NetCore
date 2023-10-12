﻿using System.ComponentModel.DataAnnotations;

namespace QLNH_WebAPIs.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
