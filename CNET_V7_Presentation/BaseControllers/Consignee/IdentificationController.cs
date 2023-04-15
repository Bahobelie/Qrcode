
using CNET_V7_Domain.DataModels.ConsigneeSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ConsigneeSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ConsigneeSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class IdentificationController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public IdentificationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdentificationById(int id)
        {
            var obj = await _serviceManager.identificationService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIdentifications()
        {
            var accounts = await _serviceManager.identificationService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIdentification([FromBody] IdentificationDTO identification)
        {
            if (identification is null)
                return BadRequest("identification is null");

            var createdObj = await _serviceManager.identificationService.Create(identification);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateIdentification([FromBody] IdentificationDTO identification)
        {
            if (identification is null) return BadRequest("identification is null");
            var updatedObject = await _serviceManager.identificationService.Update(identification);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIdentification(int id)
        {
            var deletedObject = await _serviceManager.identificationService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                