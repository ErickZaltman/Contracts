﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public enum Tables
    {
        Category, Users, Contractors, Departments, ActivityKinds
    }
    public enum Permissions
    {
        Admin = 1, Signing = 2, ReadOnly = 3, Contractor = 4, DepHead = 5, TrueSight = 6
    }
}
