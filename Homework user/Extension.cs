﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_user
{

    public static class Extension
    {
        public static bool CheckNotRobotCode(this string robotCode)
        {
            if (robotCode.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
