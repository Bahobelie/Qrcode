
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
    public class ReconciliationDetailController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ReconciliationDetailController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReconciliationDetailById(int id)
        {
            var obj = await _serviceManager.reconciliationDetailService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReconciliationDetails()
        {
            var accounts = await _serviceManager.reconciliationDetailService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReconciliationDetail([FromBody] ReconciliationDetailDTO reconciliationDetail)
        {
            if (reconciliationDetail is null)
                return BadRequest("reconciliationDetail is null");

            var createdObj = await _serviceManager.reconciliationDetailService.Create(reconciliationDetail);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReconciliationDetail([FromBody] ReconciliationDetailDTO reconciliationDetail)
        {
            if (reconciliationDetail is null) return BadRequest("reconciliationDetail is null");
            var updatedObject = await _serviceManager.reconciliationDetailService.Update(reconciliationDetail);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReconciliationDetail(int id)
        {
            var deletedObject = await _serviceManager.reconciliationDetailService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                