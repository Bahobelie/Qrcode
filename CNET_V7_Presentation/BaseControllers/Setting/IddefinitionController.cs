
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
    public class IddefinitionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public IddefinitionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIddefinitionById(int id)
        {
            var obj = await _serviceManager.iddefinitionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIddefinitions()
        {
            var accounts = await _serviceManager.iddefinitionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIddefinition([FromBody] IddefinitionDTO iddefinition)
        {
            if (iddefinition is null)
                return BadRequest("iddefinition is null");

            var createdObj = await _serviceManager.iddefinitionService.Create(iddefinition);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateIddefinition([FromBody] IddefinitionDTO iddefinition)
        {
            if (iddefinition is null) return BadRequest("iddefinition is null");
            var updatedObject = await _serviceManager.iddefinitionService.Update(iddefinition);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIddefinition(int id)
        {
            var deletedObject = await _serviceManager.iddefinitionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                