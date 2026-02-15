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

            //Employee employee = listEmployees.Find(x => employeePredicate(x));

            /***
             * Lambda expression
             */
            Employee employee = listEmployees.Find((Employee x) => {
                return x.ID == 103;
            });

            /***
             * Anonymous function
             */
            Employee employee1 = listEmployees.Find(delegate (Employee x) {
                return x.ID == 103;
            });

            Console.WriteLine(@"ID : {0}, Name : {1}, Gender : {2}, Salary : {3}",
                employee.ID, employee.Name, employee.Gender, employee.Salary);

            Console.WriteLine(@"ID : {0}, Name : {1}, Gender : {2}, Salary : {3}",
                employee1.ID, employee1.Name, employee1.Gender, employee1.Salary);

            Console.ReadKey();

            /***
             * Both the Anonymous function and lambda expression provide same result
             * Lambda expression are basically anonymous function used to create delegate
             * **/
        }

        public static bool IsEmployeeExist(Employee emp)
        {

            return emp.ID == 103;

        }
       
    }
}