
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
    public class HolidayDefinitionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public HolidayDefinitionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHolidayDefinitionById(int id)
        {
            var obj = await _serviceManager.holidayDefinitionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHolidayDefinitions()
        {
            var accounts = await _serviceManager.holidayDefinitionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHolidayDefinition([FromBody] HolidayDefinitionDTO holidayDefinition)
        {
            if (holidayDefinition is null)
                return BadRequest("holidayDefinition is null");

            var createdObj = await _serviceManager.holidayDefinitionService.Create(holidayDefinition);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateHolidayDefinition([FromBody] HolidayDefinitionDTO holidayDefinition)
        {
            if (holidayDefinition is null) return BadRequest("holidayDefinition is null");
            var updatedObject = await _serviceManager.holidayDefinitionService.Update(holidayDefinition);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHolidayDefinition(int id)
        {
            var deletedObject = await _serviceManager.holidayDefinitionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                