
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
    public class ConversionDefinitionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ConversionDefinitionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConversionDefinitionById(int id)
        {
            var obj = await _serviceManager.conversionDefinitionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllConversionDefinitions()
        {
            var accounts = await _serviceManager.conversionDefinitionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateConversionDefinition([FromBody] ConversionDefinitionDTO conversionDefinition)
        {
            if (conversionDefinition is null)
                return BadRequest("conversionDefinition is null");

            var createdObj = await _serviceManager.conversionDefinitionService.Create(conversionDefinition);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateConversionDefinition([FromBody] ConversionDefinitionDTO conversionDefinition)
        {
            if (conversionDefinition is null) return BadRequest("conversionDefinition is null");
            var updatedObject = await _serviceManager.conversionDefinitionService.Update(conversionDefinition);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConversionDefinition(int id)
        {
            var deletedObject = await _serviceManager.conversionDefinitionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                