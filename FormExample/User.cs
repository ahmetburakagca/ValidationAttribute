﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationAttribute;

namespace FormExample
{
    public class User
    {
        [RequiredField]
        public String Name { get; set; }
        public String Surname { get; set; }
    }
}
