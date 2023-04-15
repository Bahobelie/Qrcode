
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
    public class DenominationController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public DenominationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDenominationById(int id)
        {
            var obj = await _serviceManager.denominationService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDenominations()
        {
            var accounts = await _serviceManager.denominationService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDenomination([FromBody] DenominationDTO denomination)
        {
            if (denomination is null)
                return BadRequest("denomination is null");

            var createdObj = await _serviceManager.denominationService.Create(denomination);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDenomination([FromBody] DenominationDTO denomination)
        {
            if (denomination is null) return BadRequest("denomination is null");
            var updatedObject = await _serviceManager.denominationService.Update(denomination);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDenomination(int id)
        {
            var deletedObject = await _serviceManager.denominationService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                