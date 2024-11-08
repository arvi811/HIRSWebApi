using HRISbackend.Interface;
using HRISbackend.Models;

namespace HRISbackend.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly Hris2024Context _context;

        public EmployeeRepository(Hris2024Context context)
        {
            _context = context;
        }

        public bool CreateEmployee(Employee employee)
        {

            _context.Add(employee);

            return Save();
        }

        public bool DeletePokemon(Employee employee)
        {
            _context.Remove(employee);

            return Save();
        }

        public bool EmployeeExists(int employeeId)
        {
            return _context.Employee.Any(p => p.Id == employeeId);
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employee.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Employee> GetEmployees()
        {
            return _context.Employee.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            _context.Update(employee);
            return Save();
        }
    }
}
