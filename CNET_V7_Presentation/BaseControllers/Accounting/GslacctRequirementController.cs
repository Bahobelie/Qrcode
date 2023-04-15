
using CNET_V7_Domain.DataModels.AccountingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.AccountingSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.AccountingSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class GslacctRequirementController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public GslacctRequirementController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGslacctRequirementById(int id)
        {
            var obj = await _serviceManager.gslacctRequirementService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGslacctRequirements()
        {
            var accounts = await _serviceManager.gslacctRequirementService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGslacctRequirement([FromBody] GslacctRequirementDTO gslacctRequirement)
        {
            if (gslacctRequirement is null)
                return BadRequest("gslacctRequirement is null");

            var createdObj = await _serviceManager.gslacctRequirementService.Create(gslacctRequirement);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGslacctRequirement([FromBody] GslacctRequirementDTO gslacctRequirement)
        {
            if (gslacctRequirement is null) return BadRequest("gslacctRequirement is null");
            var updatedObject = await _serviceManager.gslacctRequirementService.Update(gslacctRequirement);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGslacctRequirement(int id)
        {
            var deletedObject = await _serviceManager.gslacctRequirementService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                