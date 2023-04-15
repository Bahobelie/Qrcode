
using CNET_V7_Domain.DataModels.CommonSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.CommonSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.CommonSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public LookupController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLookupById(int id)
        {
            var obj = await _serviceManager.lookupService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLookups()
        {
            var accounts = await _serviceManager.lookupService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLookup([FromBody] LookupDTO lookup)
        {
            if (lookup is null)
                return BadRequest("lookup is null");

            var createdObj = await _serviceManager.lookupService.Create(lookup);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLookup([FromBody] LookupDTO lookup)
        {
            if (lookup is null) return BadRequest("lookup is null");
            var updatedObject = await _serviceManager.lookupService.Update(lookup);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLookup(int id)
        {
            var deletedObject = await _serviceManager.lookupService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                