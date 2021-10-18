﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; } 

        void AssignManager(IEmployee manager);
    }
}
