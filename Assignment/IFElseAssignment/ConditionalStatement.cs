using System;
namespace IFElseAssignment
{
    public class ConditionalStatement
    {
        static void Main()
        {
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.90f : 30.80f;
            Console.WriteLine($"price : {price.ToString("c")}");

            //Using ifelse statement

            bool goldCustomer = true;
            if (goldCustomer)
                Console.WriteLine($"price : 19.90");
            else
                Console.WriteLine("price : 35.50");
        }

    }
}
