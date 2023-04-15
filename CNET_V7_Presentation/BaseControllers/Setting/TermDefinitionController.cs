
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
    public class TermDefinitionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public TermDefinitionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTermDefinitionById(int id)
        {
            var obj = await _serviceManager.termDefinitionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTermDefinitions()
        {
            var accounts = await _serviceManager.termDefinitionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTermDefinition([FromBody] TermDefinitionDTO termDefinition)
        {
            if (termDefinition is null)
                return BadRequest("termDefinition is null");

            var createdObj = await _serviceManager.termDefinitionService.Create(termDefinition);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTermDefinition([FromBody] TermDefinitionDTO termDefinition)
        {
            if (termDefinition is null) return BadRequest("termDefinition is null");
            var updatedObject = await _serviceManager.termDefinitionService.Update(termDefinition);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTermDefinition(int id)
        {
            var deletedObject = await _serviceManager.termDefinitionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                