using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Diagnostics.SymbolStore;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public IEnumerable<Employee> GetEmployees(Guid companyId,bool trackChanges)
        {
            return FindByCondition(e => e.CompanyId.Equals(companyId), trackChanges).OrderBy(e=>e.Name);
        }

        public Employee GetEmployee(Guid companyId,Guid employeeId,bool trackChanges)
        {
            return FindByCondition(e => e.Id.Equals(employeeId) && e.CompanyId.Equals(companyId),trackChanges).SingleOrDefault();
        }

        public void CreateEmployee(Guid companyId,Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }
        
    }
}
