
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
    public class ObjectStateController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ObjectStateController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetObjectStateById(int id)
        {
            var obj = await _serviceManager.objectStateService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllObjectStates()
        {
            var accounts = await _serviceManager.objectStateService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateObjectState([FromBody] ObjectStateDTO objectState)
        {
            if (objectState is null)
                return BadRequest("objectState is null");

            var createdObj = await _serviceManager.objectStateService.Create(objectState);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateObjectState([FromBody] ObjectStateDTO objectState)
        {
            if (objectState is null) return BadRequest("objectState is null");
            var updatedObject = await _serviceManager.objectStateService.Update(objectState);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjectState(int id)
        {
            var deletedObject = await _serviceManager.objectStateService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                