using AutoMapper;
using HRISbackend.Dto;
using HRISbackend.Interface;
using HRISbackend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HRISbackend.Controllers
{
    
    [EnableCors("AllowOrigin")]
  
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployee employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }


        
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<IEmployee>))]
        public IActionResult GetEmployees()
        {
            var employees = _mapper.Map<List<EmployeeDto>>(_employeeRepository.GetEmployees());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(employees);
        }


       
        [HttpGet("{employeeId}")]
        [ProducesResponseType(200, Type = typeof(Employee))]
        [ProducesResponseType(400)]
        public IActionResult GetEmployee(int employeeId)
        {
            if (!_employeeRepository.EmployeeExists(employeeId))
                return NotFound();

            var employee = _mapper.Map<EmployeeDto>(_employeeRepository.GetEmployee(employeeId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(employee);
        }

      
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateEmployee([FromBody] EmployeeDto employeeCreate)
        {
            if (employeeCreate == null)
                return BadRequest(ModelState);

            var employees = _employeeRepository.GetEmployees()
                .Where(c => c.Name.Trim().ToUpper() == employeeCreate.Name.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (employees != null)
            {
                ModelState.AddModelError("", "Employee already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeMap = _mapper.Map<Employee>(employeeCreate);

            if (!_employeeRepository.CreateEmployee(employeeMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }

        [EnableCors("AllowOrigin")]
        [HttpPut("{employeeId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateEmployee(int employeeId, [FromBody] EmployeeDto updatedEmployee)

        {

            if (updatedEmployee == null)
                return BadRequest(ModelState);

            if (employeeId != updatedEmployee.Id)
                return BadRequest(ModelState);

            if (!_employeeRepository.EmployeeExists(employeeId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeMap = _mapper.Map<Employee>(updatedEmployee);

            if (!_employeeRepository.UpdateEmployee(employeeMap))
            {
                ModelState.AddModelError("", "Something went wrong Updating Employee");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

       
        [HttpDelete("{employeeId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteEmployee(int employeeId)
        {
            if (!_employeeRepository.EmployeeExists(employeeId))
            {
                return NotFound();
            }

            var employeeToDelete = _employeeRepository.GetEmployee(employeeId);
            if (!_employeeRepository.DeletePokemon(employeeToDelete))

            {
                ModelState.AddModelError("", "Something went wrong deleting Employee");
            }
            return NoContent();
        }


    }
}
