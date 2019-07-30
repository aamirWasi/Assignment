namespace Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Introduce()
        {
            System.Console.WriteLine($"My Name is {FirstName}{LastName}");
        }
        static void Main()
        {
            var person = new Person()
            {
                FirstName = "aamir",
                LastName = "wasi"
            };
            person.Introduce();
        }
    }
}