namespace Dictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //The generic version of the hash table is Dictionary     
            Dictionary<int, string> dictionary = new Dictionary<int, string>() {
                {1,"numberOne" },
                { 2,"numberTwo" },
                { 3,"numberThree"}
            };


            Employee[] employees = [new Employee("CIO", "Arden", 75, 150),
                new Employee("CTO", "Hardy", 45, 125),
                new Employee("Secretary", "Katy", 37, 100),
                new Employee("HR", "Hill", 35, 100),
                new Employee("Data Analysist", "Jill", 25, 75),
                new Employee("Intern", "Faruk", 20, 50),
            ];

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee employee in employees)
            {
                //getting data from array to add a dictionary
                employeesDirectory.Add(employee.Role, employee);
            }

            //now we can call the details of the data just defining the key value which is "Role"
            //I created my own method to check the given key value is exist or not
            Employee employee1 = Employee.CheckTheDataExist("Intern", employeesDirectory);
            Employee employee2 = Employee.CheckTheDataExist("CIO", employeesDirectory);
            Employee employee3 = Employee.CheckTheDataExist("RandomValue", employeesDirectory);

            //prints the data with a method
            Employee.GetEmployee(employee1);
            Employee.GetEmployee(employee2);
            Employee.GetEmployee(employee3);

            //creates a new employee to change the existing data
            Employee newEmployee = new Employee("Intern", "Ramy", 19, 30);

            //updates employee
            Employee.UpdateEmployee("Intern", employeesDirectory, newEmployee);

            //shows the new employee
            Employee.GetEmployee(Employee.CheckTheDataExist("Intern", employeesDirectory));

            //deletes employee
            Employee.DeleteEmployee("Intern", employeesDirectory);

            Employee.GetAllDetails(employeesDirectory);

        }
    }

}