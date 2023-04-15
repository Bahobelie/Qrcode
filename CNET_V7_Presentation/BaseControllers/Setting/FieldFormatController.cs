
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
    public class FieldFormatController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public FieldFormatController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFieldFormatById(int id)
        {
            var obj = await _serviceManager.fieldFormatService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFieldFormats()
        {
            var accounts = await _serviceManager.fieldFormatService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFieldFormat([FromBody] FieldFormatDTO fieldFormat)
        {
            if (fieldFormat is null)
                return BadRequest("fieldFormat is null");

            var createdObj = await _serviceManager.fieldFormatService.Create(fieldFormat);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFieldFormat([FromBody] FieldFormatDTO fieldFormat)
        {
            if (fieldFormat is null) return BadRequest("fieldFormat is null");
            var updatedObject = await _serviceManager.fieldFormatService.Update(fieldFormat);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFieldFormat(int id)
        {
            var deletedObject = await _serviceManager.fieldFormatService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                