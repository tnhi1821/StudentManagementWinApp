﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication9.BUS
{
    public static class UtilitiesBUS
    {
        public static string ArrayToString(string[] array, int n)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1) str += array[i] + ";";
                else str += array[i];
            }
            return str;
        }
    }
}
