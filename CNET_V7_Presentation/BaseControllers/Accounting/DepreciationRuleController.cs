
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
    public class DepreciationRuleController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public DepreciationRuleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepreciationRuleById(int id)
        {
            var obj = await _serviceManager.depreciationRuleService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepreciationRules()
        {
            var accounts = await _serviceManager.depreciationRuleService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepreciationRule([FromBody] DepreciationRuleDTO depreciationRule)
        {
            if (depreciationRule is null)
                return BadRequest("depreciationRule is null");

            var createdObj = await _serviceManager.depreciationRuleService.Create(depreciationRule);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDepreciationRule([FromBody] DepreciationRuleDTO depreciationRule)
        {
            if (depreciationRule is null) return BadRequest("depreciationRule is null");
            var updatedObject = await _serviceManager.depreciationRuleService.Update(depreciationRule);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepreciationRule(int id)
        {
            var deletedObject = await _serviceManager.depreciationRuleService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                