
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
    public class ReconciliationSummaryController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ReconciliationSummaryController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReconciliationSummaryById(int id)
        {
            var obj = await _serviceManager.reconciliationSummaryService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReconciliationSummarys()
        {
            var accounts = await _serviceManager.reconciliationSummaryService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReconciliationSummary([FromBody] ReconciliationSummaryDTO reconciliationSummary)
        {
            if (reconciliationSummary is null)
                return BadRequest("reconciliationSummary is null");

            var createdObj = await _serviceManager.reconciliationSummaryService.Create(reconciliationSummary);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReconciliationSummary([FromBody] ReconciliationSummaryDTO reconciliationSummary)
        {
            if (reconciliationSummary is null) return BadRequest("reconciliationSummary is null");
            var updatedObject = await _serviceManager.reconciliationSummaryService.Update(reconciliationSummary);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReconciliationSummary(int id)
        {
            var deletedObject = await _serviceManager.reconciliationSummaryService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                