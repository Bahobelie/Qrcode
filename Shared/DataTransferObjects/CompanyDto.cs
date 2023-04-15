using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{

    //public record CompanyDto(Guid Id,string Name,string FullAddress);
    
    public record CompanyDto
    {
        public Guid Id { get; init; }//the init part is added to make this record immutable and so that xml serializer will read its field
        public string? Name { get; init; }
        public string? FullAddress { get;init; }
    }

    public record CompanyForCreationDto(string Name, string Address, string Country,IEnumerable<EmployeeForeCreationDto> employees);
    public record EmployeeDto(Guid Id, string Name, int Age, string Position);
    public record EmployeeForeCreationDto(string Name,int Age,string position);

    public record EmployeeForUpdateDto(string Name,int Age,string position);
    public record CompanyForUpdateDto(string Name,string Address,string Country,IEnumerable<EmployeeForeCreationDto> Employees);
    
}
