
using CNET_V7_Domain.DataModels.SettingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.SettingSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.SettingSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ObjectStateDefinitionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ObjectStateDefinitionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetObjectStateDefinitionById(int id)
        {
            var obj = await _serviceManager.objectStateDefinitionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllObjectStateDefinitions()
        {
            var accounts = await _serviceManager.objectStateDefinitionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateObjectStateDefinition([FromBody] ObjectStateDefinitionDTO objectStateDefinition)
        {
            if (objectStateDefinition is null)
                return BadRequest("objectStateDefinition is null");

            var createdObj = await _serviceManager.objectStateDefinitionService.Create(objectStateDefinition);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateObjectStateDefinition([FromBody] ObjectStateDefinitionDTO objectStateDefinition)
        {
            if (objectStateDefinition is null) return BadRequest("objectStateDefinition is null");
            var updatedObject = await _serviceManager.objectStateDefinitionService.Update(objectStateDefinition);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjectStateDefinition(int id)
        {
            var deletedObject = await _serviceManager.objectStateDefinitionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                