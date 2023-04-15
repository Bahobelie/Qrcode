
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
    public class TrialBalanceController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public TrialBalanceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrialBalanceById(int id)
        {
            var obj = await _serviceManager.trialBalanceService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTrialBalances()
        {
            var accounts = await _serviceManager.trialBalanceService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrialBalance([FromBody] TrialBalanceDTO trialBalance)
        {
            if (trialBalance is null)
                return BadRequest("trialBalance is null");

            var createdObj = await _serviceManager.trialBalanceService.Create(trialBalance);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTrialBalance([FromBody] TrialBalanceDTO trialBalance)
        {
            if (trialBalance is null) return BadRequest("trialBalance is null");
            var updatedObject = await _serviceManager.trialBalanceService.Update(trialBalance);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrialBalance(int id)
        {
            var deletedObject = await _serviceManager.trialBalanceService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                