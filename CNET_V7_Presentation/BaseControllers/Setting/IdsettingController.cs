
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
    public class IdsettingController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public IdsettingController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdsettingById(int id)
        {
            var obj = await _serviceManager.idsettingService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIdsettings()
        {
            var accounts = await _serviceManager.idsettingService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIdsetting([FromBody] IdsettingDTO idsetting)
        {
            if (idsetting is null)
                return BadRequest("idsetting is null");

            var createdObj = await _serviceManager.idsettingService.Create(idsetting);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateIdsetting([FromBody] IdsettingDTO idsetting)
        {
            if (idsetting is null) return BadRequest("idsetting is null");
            var updatedObject = await _serviceManager.idsettingService.Update(idsetting);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIdsetting(int id)
        {
            var deletedObject = await _serviceManager.idsettingService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                