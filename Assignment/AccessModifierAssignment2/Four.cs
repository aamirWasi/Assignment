using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierAssignment2
{
    //without print internal(bcoz in different project)
    class Four: AccessModifierAssignment.Program
    {
        static void Main(string[] args)
        {
            var four = new Four();
            four.Test3();
            four.Test4();
            four.Test5();
        }
    }
}
