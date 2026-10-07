
class Program
{

    public class EmployeeManager
    {
        private List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public void ViewAllEmployees()
        {
            foreach (Employee emp in _employees)
            {
                Console.WriteLine(emp.Name);
            }

        }



    }

    public enum Department
    {
        HR = 1,
        IT = 2,
        Sales = 3
    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public decimal Salary { get; set; }

        public Department Department { get; set; }

        public DateOnly Joiningdate { get; set; }

        public Employee(int id, string name, string email, decimal salary, Department department, DateOnly date)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Department = department;
            this.Joiningdate = date;
            this.Salary = salary;


        }

        public static void Main(string[] args)
        {
            Employee emp = new Employee(20, "Surendra", "surendraloke18@gmail.com", 1000000, Department.Sales, new DateOnly(2026, 10, 07));
        }


    }

}

