using System;

namespace part_4
{
    //Person class start
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }

    }
    //Student Class Start
    class Student : Person
    {
        public string Campus { get; set; }
        public int StudentID { get; set; }

        public Student(string firstname, string lastname, string campus) : base(firstname, lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Campus = campus;
        }

        public int EnrollStudent()
        {

            Random item = new Random();

            return item.Next(1000, 10000);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ClearConsole
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This Program takes user input on the asked fields and returns it");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            //loops
            char inputYnN;
            do
            {
                //users input
                Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
                Console.WriteLine("Enter new student details below");
                Student snew = new Student("", "", "");
                Console.Write("Enter First Name: ");
                snew.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                snew.LastName = Console.ReadLine();
                Console.Write("Enter Campus: ");
                snew.Campus = Console.ReadLine();
                Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
                Console.WriteLine();
                Console.WriteLine("Creating new person record ......");
                Console.WriteLine();
                Console.WriteLine("Adding new student record to " + snew.Campus + " campus......");
                Console.WriteLine();
                //return data
                Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
                Console.WriteLine(snew.GetFullName() + " of " + snew.Campus + " campus has a student ID of " + snew.EnrollStudent());
                Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
                
                
                Console.WriteLine("Would you like to add a new Person Y/N");
                inputYnN = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            while (char.ToLower(inputYnN) == 'y');
            //Loop end
            //program end
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("**************PROGRAM END***************");
            Console.WriteLine("Please Press <any key> to quit the program");
            Console.ReadKey();
        }
    }
}
