
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
    public class PreferenceAccessController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public PreferenceAccessController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPreferenceAccessById(int id)
        {
            var obj = await _serviceManager.preferenceAccessService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPreferenceAccesss()
        {
            var accounts = await _serviceManager.preferenceAccessService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePreferenceAccess([FromBody] PreferenceAccessDTO preferenceAccess)
        {
            if (preferenceAccess is null)
                return BadRequest("preferenceAccess is null");

            var createdObj = await _serviceManager.preferenceAccessService.Create(preferenceAccess);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePreferenceAccess([FromBody] PreferenceAccessDTO preferenceAccess)
        {
            if (preferenceAccess is null) return BadRequest("preferenceAccess is null");
            var updatedObject = await _serviceManager.preferenceAccessService.Update(preferenceAccess);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreferenceAccess(int id)
        {
            var deletedObject = await _serviceManager.preferenceAccessService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                