namespace OopClassMembers
{
    internal class Person
    {
        private string _firstName = "John";

        private string _fastName = "Doe";

        // readonly field can be modified from the initialization expression (#1)
        private readonly string _cnp = "1234";

        private static int populationCount = 0;

        public static readonly int MaxLifespanYears = InitMaxLifespan();

        // this is a constructor
        public Person(string cnp)
        {
            // readonly field can be modified from the constructor (#2)
            _cnp = cnp;
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
