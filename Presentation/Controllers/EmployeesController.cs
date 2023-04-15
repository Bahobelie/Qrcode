using Azure;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/companies/{companyId}/employees")]
    [ApiController]
    public class EmployeesController :ControllerBase
    {
        private readonly IServiceManager _service;
        public EmployeesController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetEmployeesForCompany(Guid companyId)
        {
            var employees = _service.EmployeeService.GetEmployees(companyId, false);
            return Ok(employees);
        }
        [HttpGet("{employeeId:guid}", Name = "GetEmployeeByCompanyAndId")]
        public IActionResult GetEmployee(Guid companyId, Guid employeeId)
        {
            var employee = _service.EmployeeService.GetEmployee(companyId,employeeId,false);
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult CreateEmployee(Guid companyId, [FromBody]EmployeeForeCreationDto employee)
        {
            if (employee is null)
                return BadRequest("Employee Object is null");

            var empToReturn = _service.EmployeeService.CreateEmployee(companyId, employee, trackChanges: false);

            return CreatedAtRoute("GetEmployeeByCompanyAndId", new { companyId, employeeId = empToReturn.Id},empToReturn);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteEmployeeForCompany(Guid companyId,Guid id) { 
            _service.EmployeeService.DeleteEmployeeForCompany(companyId,id,false);
            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateEmployeeForCompany(Guid companyId,Guid id, [FromBody]EmployeeForUpdateDto employee)
        {
            if (employee is null)
                return BadRequest("Employee is null");
            _service.EmployeeService.UpdateEmployeeForCompany(companyId, id, employee, false, true);
            return NoContent();
        }
        //in order for this request to work: 1. you have to set the custom content-type to application/json-patch+json and send your request in square brackets(array format)
        [HttpPatch("{id:guid}")]
        public IActionResult PartiallyUpdateEmployeeForCompany(Guid companyId,Guid id, [FromBody] JsonPatchDocument<EmployeeForUpdateDto> patchDoc)
        {
            if (patchDoc is null)
                return BadRequest("patch doc is null");
            var result = _service.EmployeeService.GetEmployeeForPatch(companyId,id,compTrackChanges:false,empTrackChanges:true);

            patchDoc.ApplyTo(result.employeeToPatch);
            _service.EmployeeService.SaveChangesForPatch(result.employeeToPatch, result.employeeEntity);
            return NoContent();
        }

    }
}
