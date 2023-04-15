
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
    public class CnetlicenseController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public CnetlicenseController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCnetlicenseById(int id)
        {
            var obj = await _serviceManager.cnetlicenseService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCnetlicenses()
        {
            var accounts = await _serviceManager.cnetlicenseService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCnetlicense([FromBody] CnetlicenseDTO cnetlicense)
        {
            if (cnetlicense is null)
                return BadRequest("cnetlicense is null");

            var createdObj = await _serviceManager.cnetlicenseService.Create(cnetlicense);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCnetlicense([FromBody] CnetlicenseDTO cnetlicense)
        {
            if (cnetlicense is null) return BadRequest("cnetlicense is null");
            var updatedObject = await _serviceManager.cnetlicenseService.Update(cnetlicense);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCnetlicense(int id)
        {
            var deletedObject = await _serviceManager.cnetlicenseService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                