﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDesign
{
    //I understood LSP Properly

    //Added updated version for this this
    class Program
    {
        static void Main(string[] args)
        {
            var mathTeacher = new MathTeacher();
            mathTeacher.Teach();
            mathTeacher.PerformOtherResponsibilities();
        }
    }
}
