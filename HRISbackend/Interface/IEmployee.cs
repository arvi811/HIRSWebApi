using HRISbackend.Models;

namespace HRISbackend.Interface
{
    public interface IEmployee
    {
        ICollection<Employee> GetEmployees();
        Employee GetEmployee(int id);
        bool EmployeeExists(int employeeId);
        bool CreateEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeletePokemon(Employee employee);
        bool Save();
    }
}
