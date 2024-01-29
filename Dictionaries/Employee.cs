namespace Dictionaries
{
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                //This calculation is: yearly salary = rate * number of dates * number of weeks * number of months
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            Role = role;
            Name = name;
            Age = age;
            Rate = rate;
        }

        public static void GetEmployee(Employee emp)
        {
            try
            {
                Console.WriteLine($"The details of the employee: Name: {emp.Name}, Age: {emp.Age}, Role: {emp.Role}, Salary (Yearly): {emp.Salary}");
            }
            catch (Exception)
            {
                Console.WriteLine("There is some issue on your data!");
            }
        }

        public static Employee CheckTheDataExist(string key, Dictionary<string, Employee> employeesDirectory)
        {
            if (employeesDirectory.ContainsKey(key))
            {
                Employee employee1 = employeesDirectory[key];
                return employee1;
            }
            else
            {
                Console.WriteLine($"Your key value {(key)} is not correct!");
                return null;
            }
        }

        public static void UpdateEmployee(string keyToUpdate, Dictionary<string, Employee> employeesDictionary, Employee newEmployee)
        {
            if (employeesDictionary.ContainsKey(keyToUpdate))
            {
                employeesDictionary[keyToUpdate] = new Employee(newEmployee.Role, newEmployee.Name, newEmployee.Age, newEmployee.Rate);
                Console.WriteLine($"Your employee '{keyToUpdate}' is updated!");
            }
        }

        public static void DeleteEmployee(string keyToDelete, Dictionary<string, Employee> employeesDictionary)
        {
            if (employeesDictionary.Remove(keyToDelete))
            {
                Console.WriteLine($"Your employee '{keyToDelete}' is removed!");
            }
        }

        public static void GetAllDetails(Dictionary<string, Employee> employeesDirectory)
        {
            //gets all the data from Dictionary
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Employee empValue = keyValuePair.Value;

                GetEmployee(empValue);
            }
        }
    }
}
