﻿using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public EmployeeService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<EmployeeDto> GetEmployees(Guid companyId, bool trackChanges)
        {
            var company = _repository.Company.GetCompany(companyId, trackChanges);
            if (company is null)
                throw new CompanyNotFoundException(companyId);

            var employees = _repository.Employee.GetEmployees(companyId, trackChanges);
            var employeeDto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return employeeDto;
        }

        public EmployeeDto GetEmployee(Guid companyId, Guid employeeId, bool trackChanges)
        {
            var company = _repository.Company.GetCompany(companyId,trackChanges);
            if(company is null)
                throw new CompanyNotFoundException(companyId);

            var employee = _repository.Employee.GetEmployee(companyId,employeeId,trackChanges);
            if (employee is null)
                throw new EmployeeNotFoundException(employeeId);

            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            return employeeDto;
        }

        public EmployeeDto CreateEmployee(Guid companyId, EmployeeForeCreationDto employee,bool trackChanges)
        {
            var company = _repository.Company.GetCompany(companyId,trackChanges);
            if (company is null)
                throw new CompanyNotFoundException(companyId);

            var employeeEntity = _mapper.Map<Employee>(employee);

            _repository.Employee.CreateEmployee(companyId, employeeEntity);
            _repository.Save();

            var employeeToReturn = _mapper.Map<EmployeeDto>(employeeEntity);
            return employeeToReturn;
        }

        public void DeleteEmployeeForCompany(Guid companyId,Guid id,bool trackchanges)
        {
            var company = _repository.Company.GetCompany(companyId, trackchanges);
            if (company is null)
                throw new CompanyNotFoundException(companyId);

            var employeeForCompany = _repository.Employee.GetEmployee(companyId,id, trackchanges);
            if(employeeForCompany is null) throw new EmployeeNotFoundException(id);
            _repository.Employee.DeleteEmployee(employeeForCompany);
            _repository.Save();
        }

        public void UpdateEmployeeForCompany(Guid companyId, Guid id, EmployeeForUpdateDto employeeForUpdate, bool compTrackChanges, bool empTrackChanges)
        {
            var company = _repository.Company.GetCompany(companyId, compTrackChanges);
            if(company is null)
                throw new CompanyNotFoundException(companyId);
            var employeeEntity = _repository.Employee.GetEmployee(companyId,id,empTrackChanges);
            if(employeeEntity is null)
                throw new EmployeeNotFoundException(id);

            _mapper.Map(employeeForUpdate, employeeEntity);//this will trigger Modified state on our entity
            _repository.Save();
        }

        public (EmployeeForUpdateDto employeeToPatch, Employee employeeEntity) GetEmployeeForPatch(Guid companyId, Guid id, bool compTrackChanges, bool empTrackChanges)
        {
            var company = _repository.Company.GetCompany(companyId, compTrackChanges);
            if(company is null)
                throw new CompanyNotFoundException(companyId);
            var employeeEntity = _repository.Employee.GetEmployee(companyId, id, empTrackChanges);
            if (employeeEntity is null)
                throw new EmployeeNotFoundException(id);

            var employeeToPatch = _mapper.Map<EmployeeForUpdateDto>(employeeEntity);
            return (employeeToPatch, employeeEntity);
        }

        public void SaveChangesForPatch(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity)
        {
           _mapper.Map(employeeToPatch, employeeEntity);
            _repository.Save();
        }
    }
}
