
using CNET_V7_Domain.DataModels.SecuritySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.SecuritySchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.SecuritySchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class FunctionalityController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public FunctionalityController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFunctionalityById(int id)
        {
            var obj = await _serviceManager.functionalityService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFunctionalitys()
        {
            var accounts = await _serviceManager.functionalityService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFunctionality([FromBody] FunctionalityDTO functionality)
        {
            if (functionality is null)
                return BadRequest("functionality is null");

            var createdObj = await _serviceManager.functionalityService.Create(functionality);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFunctionality([FromBody] FunctionalityDTO functionality)
        {
            if (functionality is null) return BadRequest("functionality is null");
            var updatedObject = await _serviceManager.functionalityService.Update(functionality);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFunctionality(int id)
        {
            var deletedObject = await _serviceManager.functionalityService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                