namespace Classes
{
    public class Calculator
    {
        public static int Add()
        {
            var x = 3;
            var y = 5;
            return x + y;
        }
        public static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            return sum;
        }
        static void Main()
        {
            var result = Calculator.Add();
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var sumResult = Calculator.Sum(arr);
            System.Console.WriteLine(result);
            System.Console.WriteLine(sumResult);
        }
    }
}