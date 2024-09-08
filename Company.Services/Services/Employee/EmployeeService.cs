using AutoMapper;
using Company.Data.Entities;
using Company.Repositiry.Interfaces;
using Company.Services.Helper;
using Company.Services.Interfaces;
using Company.Services.Interfaces.Employee.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(EmployeeDto employeeDto)
        {
            //Employee employee = new Employee
            //{
            //    Name = employeeDto.Name,
            //    Address = employeeDto.Address,
            //    Age = employeeDto.Age,
            //    DepartmentId = employeeDto.DepartmentId,
            //    Email = employeeDto.Email,
            //    HiringDate = employeeDto.HiringDate,
            //    ImageUrl = employeeDto.ImageUrl,
            //    PhoneNumber = employeeDto.PhoneNumber,
            //    Salary = employeeDto.Salary
            //};

            employeeDto.ImageUrl = DocumentSettings.UploadFile(employeeDto.Image, "Images");

            Employee employee = _mapper.Map<Employee>(employeeDto);

            _unitOfWork.EmployeeRepository.Add(employee);
            _unitOfWork.Complete();
        }

        public void Delete(EmployeeDto employeeDto)
        {
            //Employee employee = new Employee
            //{
            //    Name = employeeDto.Name,
            //    Address = employeeDto.Address,
            //    Age = employeeDto.Age,
            //    DepartmentId = employeeDto.DepartmentId,
            //    Email = employeeDto.Email,
            //    HiringDate = employeeDto.HiringDate,
            //    ImageUrl = employeeDto.ImageUrl,
            //    PhoneNumber = employeeDto.PhoneNumber,
            //    Salary = employeeDto.Salary
            //};

            Employee employee = _mapper.Map<Employee>(employeeDto);

            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Complete();
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            var employees = _unitOfWork.EmployeeRepository.GetAll();

            //var mappedEmployees = employees.Select(x => new EmployeeDto
            //{
            //    DepartmentId = x.DepartmentId,
            //    Email = x.Email,
            //    HiringDate = x.HiringDate,
            //    ImageUrl = x.ImageUrl,
            //    PhoneNumber = x.PhoneNumber,
            //    Salary = x.Salary,
            //    Name = x.Name,
            //    Id = x.Id,
            //    Address = x.Address,
            //    Age= x.Age,
            //    CreateAt = x.CreateAt
            //});

            IEnumerable<EmployeeDto> mappedEmployees = _mapper.Map<IEnumerable<EmployeeDto>>(employees);

            return mappedEmployees;
        }

        public EmployeeDto GetById(int? id)
        {
            if (id is null)
                return null;

            var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);

            if (employee is null)
                return null;

            //EmployeeDto employeeDto = new EmployeeDto
            //{
            //    Name = employee.Name,
            //    Address = employee.Address,
            //    Age = employee.Age,
            //    DepartmentId = employee.DepartmentId,
            //    Email = employee.Email,
            //    HiringDate = employee.HiringDate,
            //    ImageUrl = employee.ImageUrl,
            //    PhoneNumber = employee.PhoneNumber,
            //    Salary = employee.Salary,
            //    Id = employee.Id,
            //    CreateAt = employee.CreateAt
            //};

            EmployeeDto employeeDto = _mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        public IEnumerable<EmployeeDto> GetEmployeeByName(string name)
        {
            var employees = _unitOfWork.EmployeeRepository.GetEmployeeByName(name);

            //var mappedEmployees = employees.Select(x => new EmployeeDto
            //{
            //    DepartmentId = x.DepartmentId,
            //    Email = x.Email,
            //    HiringDate = x.HiringDate,
            //    ImageUrl = x.ImageUrl,
            //    PhoneNumber = x.PhoneNumber,
            //    Salary = x.Salary,
            //    Name = x.Name,
            //    Id = x.Id,
            //    Address = x.Address,
            //    Age = x.Age,
            //    CreateAt = x.CreateAt
            //});

            IEnumerable<EmployeeDto> mappedEmployees = _mapper.Map<IEnumerable<EmployeeDto>>(employees);

            return mappedEmployees;

        }

        public void Update(EmployeeDto employeeDto)
        {
            //Employee employee = new Employee
            //{
            //    Name = employeeDto.Name,
            //    Address = employeeDto.Address,
            //    Age = employeeDto.Age,
            //    DepartmentId = employeeDto.DepartmentId,
            //    Email = employeeDto.Email,
            //    HiringDate = employeeDto.HiringDate,
            //    ImageUrl = employeeDto.ImageUrl,
            //    PhoneNumber = employeeDto.PhoneNumber,
            //    Salary = employeeDto.Salary
            //};

            //_unitOfWork.EmployeeRepository.Update(employee);
            //_unitOfWork.Complete();
        }
    }
}
