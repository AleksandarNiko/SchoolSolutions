﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students
{
    public interface IStudent
    {
        string Info();

        bool Approval();

        double AverageSuccess();
    }
}