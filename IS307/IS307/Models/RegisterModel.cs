﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS307.Models
{
    public class RegisterModel
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string passwordConfirm { get; set; }
    }
}