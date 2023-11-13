namespace OopClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArray intArray = new IntArray(new[] { 1, 2, 3 });
            int min = intArray.Min();
            intArray[0] = 123;


            int noOfPersons = ReadNumber("Number of persons=", 3);
            Person[] arrayOfPersons = new Person[noOfPersons];
            for (int i = 0; i < arrayOfPersons.Length; i++)
            {
                Console.WriteLine($"Reading person at index {i}");

                Console.Write("FirstName=");
                string firstName = Console.ReadLine();

                Console.Write("LastName=");
                string lastName = Console.ReadLine();

                Console.Write("CNP=");
                string cnp = Console.ReadLine();

                Person p = new Person(cnp);
                p.FirstName = firstName;
                p.LastName = lastName;

                arrayOfPersons[i] = p;
            }

            Console.WriteLine("Printing persons: ");
            for (int i = 0; i < arrayOfPersons.Length; i++)
            {
                //arrayOfPersons[i].PrintPerson();
                Person p = arrayOfPersons[i];
                Console.WriteLine(p.FirstName + " " + p.LastName + " - CNP: " + p.Cnp);
            }

            Console.WriteLine("Total population count: " + Person.PopulationCount);




            //int maxLifespan = Person.MaxLifespanYears;
            //Person p = new Person("2344");
            //p.FirstName = "Florin";

                //Console.WriteLine(Person.PopulationCount);
                //Console.WriteLine(p.FirstName);
                //Console.WriteLine(p.LastName);
                //Console.WriteLine(p.Cnp);


                //Person.MaxLifespanYears
                //p.Cnp = "2344";
                //Person.PopulationCount = 1;
        }

        static int ReadNumber(string label, int maxAttempts)
        {
            int attempts = 1;
            do
            {
                Console.Write(label);
                string input = Console.ReadLine();
                bool isValidNumber = int.TryParse(input, out int result);

                if (isValidNumber)
                {
                    return result;
                }

                if (attempts < maxAttempts)
                {
                    Console.WriteLine($"Value '{input}' is not a valid number, please try again.");
                }

                attempts++;
            }
            while (attempts <= maxAttempts);

            Console.WriteLine($"No valid numeric input, continuing with 0 as default value.");
            return 0;
        }
    }
}