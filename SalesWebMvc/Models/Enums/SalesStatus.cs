﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.Enums
{
    public enum SalesStatus :int
    {
        Pending= 0,
        bill= 1,
        cancel= 2
    }
}