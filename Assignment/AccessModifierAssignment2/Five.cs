namespace AccessModifierAssignment2
{
    //only print public method (bcoz in different project and not child class)
    public class Five
    {
        static void Main()
        {
            var p = new AccessModifierAssignment.Program();
            p.Test5();
        }
    }
}
