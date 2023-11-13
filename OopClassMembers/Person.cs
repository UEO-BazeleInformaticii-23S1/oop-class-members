namespace OopClassMembers
{
    internal class Person
    {
        public static readonly int MaxLifespanYears = InitMaxLifespan();

        // this is a constructor
        public Person(string cnp)
        {
            // readonly field can be modified from the constructor (#2)
            Cnp = cnp;

            // each time a new person gets created, populationCount is incremented
            Person.PopulationCount++;
        }

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Cnp
        {
            get;
        }

        public static int PopulationCount { get; private set; } = 0;

        public void PrintPerson()
        {
            Console.WriteLine($"{FirstName} {LastName} - CNP: {Cnp}");
        }

        public static void PrintPopulationCount()
        {

        }

        public static int InitMaxLifespan()
        {
            return 125;
            //Console.Write("Max Lifespan=");
            //return Convert.ToInt32(Console.ReadLine());
        }
    }
}
