using DependencyInjectionPOC.Interfaces;
using DependencyInjectionPOC.Model;

namespace DependencyInjectionPOC.Services;

public class EmployeeService : IEmployeeService
{
    private List<Employee> _employeeList;  
    public EmployeeService()
    {
        _employeeList = new List<Employee>()
    {
        new Employee() { Id =1, Name = "Mary", Department ="HR", Email = "mary@gmail.com"},
        new Employee() { Id =2, Name = "John", Department ="IT", Email = "john@gmail.com"},
        new Employee() { Id =3, Name = "Sam", Department ="IT", Email = "sam@gmail.com"}


    };
    }
    public Employee GetEmployee(int Id)
    {
        return _employeeList.Find(e => e.Id == Id) ?? new Employee();
    }
}


