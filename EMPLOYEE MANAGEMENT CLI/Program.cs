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

        public Employee FindEmployeeById(int id)
        {
            foreach (Employee emp in _employees)
            {

                if (emp.Id == id)
                {

                    return emp;
                }


            }

            return null;

        }

        public void UpdateEmployeeSalary(int id, decimal salary)
        {
            Employee empToUpdate = FindEmployeeById(id);


            if (empToUpdate != null)
            {

                empToUpdate.Salary = salary;
                Console.WriteLine("Successfully updated salary to: " + salary);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

        }

        public void DeleteEmployee(int id)
        {
            Employee empToDelete = FindEmployeeById(id);

            if (empToDelete != null)
            {
                _employees.Remove(empToDelete);
                Console.WriteLine("Employee Deleted.");
            }
            else
            {
                Console.WriteLine("Not Found");

            }

        }

        public List<Employee> FilterByDepartment(Department department)
        {
            if (department != null)
            {
                return _employees.Where(e => e.Department == department).ToList();
            }
            else
            {
                return null;
            }


        }

        public decimal CalculateAverageSalary()
        {
            decimal avg = _employees.Average(e => e.Salary);

            return avg;

        }

        public Employee HighestSalary()
        {
            if (_employees.Count == 0) return null;
            decimal maxSalary = _employees.Max(e => e.Salary);
            return _employees.FirstOrDefault(e => e.Salary == maxSalary);
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

            public DateOnly JoiningDate { get; set; }

            public Employee(int id, string name, string email, decimal salary, Department department, DateOnly date)
            {
                this.Id = id;
                this.Name = name;
                this.Email = email;
                this.Department = department;
                this.JoiningDate = date;
                this.Salary = salary;


            }



            public static void Main(string[] args)
            {

                //Employee emp = new Employee(20, "Surendra", "surendraloke18@gmail.com", 1000000, Department.Sales, new DateOnly(2026, 10, 07));
                //Employee emp1 = new Employee(10, "Sonu", "surendra@gmail.com", 2000000, Department.IT, new DateOnly(2026, 11, 07));
                //EmployeeManager m1 = new EmployeeManager();
                //m1.AddEmployee(emp);
                //m1.AddEmployee(emp1);
                //m1.ViewAllEmployees();
                //var foundemp = m1.FindEmployeeById(20);

                //if (foundemp != null)
                //{
                //    Console.WriteLine(foundemp.Id);
                //    Console.WriteLine(foundemp.Name);
                //}
                //else
                //{
                //    Console.WriteLine("Not found");
                //}

                //m1.UpdateEmployeeSalary(20, 2000000);
                ////m1.DeleteEmployee(10);
                //List<Employee> l1 = m1.FilterByDepartment(Department.Sales);

                //if (l1 == null || l1.Count == 0)
                //{
                //    Console.WriteLine("No employees found in the Sales department.");
                //}
                //else
                //{
                //    foreach (var li in l1)
                //    {
                //        Console.WriteLine(li.Name);
                //        Console.WriteLine(li.Department);
                //    }
                //}

                //decimal avg = m1.CalculateAverageSalary();

                //Console.WriteLine(avg);

                //var highest = m1.HighestSalary();

                //Console.WriteLine(highest);

            }




        }

        public class ContractEmployee : Employee
        {
            public int ContractDurationMonths { get; set; }
            public ContractEmployee(int id, string name, string email, decimal salary, Department department, DateOnly date, int contractDuration) : base(id, name, email, salary, department, date)
            {
                this.ContractDurationMonths = contractDuration;
            }
        }

    }
}

