﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_cafe_film.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]

        public string username { set; get; }
        public string password { set; get; }
        public bool remember { set; get; }

    }
}