using Anonymous_Method_In_Real_Time;

namespace AnonymousMethodInRealTime
{
    class Program
    {

        public static void Main(string[] args)
        {

            Predicate<Employee> employeePredicate = new Predicate<Employee>(IsEmployeeExist);


            //Create a collection of List of Employees
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 100000},
                new Employee{ ID = 102, Name = "Priyanka", Gender = "Female", Salary = 200000},
                new Employee{ ID = 103, Name = "Anurag", Gender = "Male", Salary = 300000},
                new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000},
                new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000},
            };

            Employee employee = listEmployees.Find(x => employeePredicate(x));

            Console.WriteLine(@"ID : {0}, Name : {1}, Gender : {2}, Salary : {3}",
                employee.ID, employee.Name, employee.Gender, employee.Salary);

            Console.ReadKey();
        }

        public static bool IsEmployeeExist(Employee emp)
        {

            return emp.ID == 103;

        }
       
    }
}