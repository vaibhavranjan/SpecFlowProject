﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.CustomException
{
    public class NoSuchDriverFound : Exception
    {
        public NoSuchDriverFound(string msg) : base(msg)
        { 
        }
    }
}
