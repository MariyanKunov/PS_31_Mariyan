﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public System.Int32 UserId { get; set; }

        public System.String Username{ get; set; }

        public System.DateTime Created { get; set; }
        public System.DateTime? ActiveTill { get; set; }

        public System.String Password { get; set; }
        public System.String FakNum { get; set; }
        public System.Int32 Role { get; set; }



    }
}
