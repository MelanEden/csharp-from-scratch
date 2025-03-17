namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("¡Welcome to the calculator of years!");
            Console.WriteLine("Writing your name: ");
            nameInput=Console.ReadLine();
            Console.WriteLine($"Is pleasure to know {nameInput}");
            Console.WriteLine("Writing your date of Birthday (dd/mm/yy): ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput,out dateConverted);
            if(isDateValid==false)Console.WriteLine($"Your date Birthday is not valid, this value is wrong {birthdayInput} ");
            var person = new Person{
                name   = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year-dateConverted.Year
            };
            Console.WriteLine($"Your name: {person.name}");
            Console.WriteLine($"Your birthday: {person.Birthday}");
            Console.WriteLine($"Your Age is: {person.Age} Years");
            Console.WriteLine();
        }
    }
    public class Person
    {
        public string name { get; set; }

        public int Age { get; set; }

        public DateOnly Birthday { get; set; }
    }
}
