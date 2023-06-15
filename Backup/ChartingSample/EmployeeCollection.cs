
namespace ChartingSample
{
    class EmployeeCollection : System.Collections.ObjectModel.Collection<Employee>
    {
        public EmployeeCollection()
        {
            Add(new Employee { Title = "CEO", MinSalary = 110, MaxSalary = 160 });
            Add(new Employee { Title = "Project Manager", MinSalary = 80, MaxSalary = 120 });
            Add(new Employee { Title = "Project Leader", MinSalary = 80, MaxSalary = 105 });
            Add(new Employee { Title = "Developer", MinSalary = 55.5, MaxSalary = 90.5  });
            Add(new Employee { Title = "DBA", MinSalary = 60.75, MaxSalary = 95.5 });
        }
    }
}
