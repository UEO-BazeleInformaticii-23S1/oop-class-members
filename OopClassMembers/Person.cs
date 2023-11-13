namespace OopClassMembers
{
    internal class Person
    {
        private string _firstName = "John";

        private string _lastName = "Doe";

        // readonly field can be modified from the initialization expression (#1)
        private readonly string _cnp = "1234";

        private static int _populationCount = 0;

        public static readonly int MaxLifespanYears = InitMaxLifespan();

        // this is a constructor
        public Person(string cnp)
        {
            // readonly field can be modified from the constructor (#2)
            _cnp = cnp;

            // each time a new person gets created, populationCount is incremented
            Person._populationCount++;
        }

        public string FirstName
        {
            get 
            {
                return _firstName;
            }
            set 
            { 
                if (!string.IsNullOrEmpty(value))
                {
                    _firstName = value;
                }
                else
                {
                    // or raise error
                    _firstName = string.Empty;
                }
                
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Cnp
        {
            get { return _cnp; }
        }

        public static int PopulationCount
        {
            get { return Person._populationCount; }
        }

        public void PrintPerson()
        {
            
        }

        public static void PrintPopulationCount()
        {

        }

        public static int InitMaxLifespan()
        {
            Console.Write("Max Lifespan=");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
