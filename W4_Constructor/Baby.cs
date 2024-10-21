namespace W4_Constructor
{
    public class Baby
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;

        // getters and setters
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }

        // empty constructor
        public Baby()
        {
            Console.WriteLine("Ingaaaa");
            _birthDate = DateTime.Now;
        }

        // constructor with parameters
        public Baby(string firstName, string lastName)
        {
            Console.WriteLine("Ingaaaa");
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = DateTime.Now;
        }

        // introduce method
        public void Introduce()
        {
            Console.WriteLine("Name of the baby is {0} {1} and he/she was born on {2}", _firstName, _lastName, _birthDate);
        }
    }
}
