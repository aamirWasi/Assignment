using System;
namespace AccessModifierAssignment
{
    //Without private method all methods are showed
    public class Two:Program
    {
        static void Main()
        {
            var two = new Two();
            two.Test2();
            two.Test3();
            two.Test4();
            two.Test5();
        }
    }
}
