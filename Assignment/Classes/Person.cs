namespace Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public void Introduce()
        {
            System.Console.WriteLine($"My Name is {FirstName}");
        }
        public static Person Parse(string str)
        {
            var person = new Person
            {
                FirstName = str
            };
            return person;
        }
        static void Main()
        {
            var person = Person.Parse("aamir wasi");
            person.Introduce();
        }
    }
}