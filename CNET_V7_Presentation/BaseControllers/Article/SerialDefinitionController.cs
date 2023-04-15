
using CNET_V7_Domain.DataModels.ArticleSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ArticleSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ArticleSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class SerialDefinitionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SerialDefinitionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSerialDefinitionById(int id)
        {
            var obj = await _serviceManager.serialDefinitionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSerialDefinitions()
        {
            var accounts = await _serviceManager.serialDefinitionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSerialDefinition([FromBody] SerialDefinitionDTO serialDefinition)
        {
            if (serialDefinition is null)
                return BadRequest("serialDefinition is null");

            var createdObj = await _serviceManager.serialDefinitionService.Create(serialDefinition);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSerialDefinition([FromBody] SerialDefinitionDTO serialDefinition)
        {
            if (serialDefinition is null) return BadRequest("serialDefinition is null");
            var updatedObject = await _serviceManager.serialDefinitionService.Update(serialDefinition);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSerialDefinition(int id)
        {
            var deletedObject = await _serviceManager.serialDefinitionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                