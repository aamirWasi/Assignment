namespace IFElseAssignment
{
    public class ConditionalStatement
    {
        static void Main()
        {
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.90f : 30.80f;
            System.Console.WriteLine($"price : {price.ToString("c")}");
        }

    }
}
