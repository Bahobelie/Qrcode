
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
    public class ActivityDefinitionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ActivityDefinitionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivityDefinitionById(int id)
        {
            var obj = await _serviceManager.activityDefinitionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllActivityDefinitions()
        {
            var accounts = await _serviceManager.activityDefinitionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivityDefinition([FromBody] ActivityDefinitionDTO activityDefinition)
        {
            if (activityDefinition is null)
                return BadRequest("activityDefinition is null");

            var createdObj = await _serviceManager.activityDefinitionService.Create(activityDefinition);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateActivityDefinition([FromBody] ActivityDefinitionDTO activityDefinition)
        {
            if (activityDefinition is null) return BadRequest("activityDefinition is null");
            var updatedObject = await _serviceManager.activityDefinitionService.Update(activityDefinition);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivityDefinition(int id)
        {
            var deletedObject = await _serviceManager.activityDefinitionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                