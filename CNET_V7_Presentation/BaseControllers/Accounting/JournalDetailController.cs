
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
    public class JournalDetailController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public JournalDetailController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetJournalDetailById(int id)
        {
            var obj = await _serviceManager.journalDetailService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJournalDetails()
        {
            var accounts = await _serviceManager.journalDetailService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJournalDetail([FromBody] JournalDetailDTO journalDetail)
        {
            if (journalDetail is null)
                return BadRequest("journalDetail is null");

            var createdObj = await _serviceManager.journalDetailService.Create(journalDetail);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateJournalDetail([FromBody] JournalDetailDTO journalDetail)
        {
            if (journalDetail is null) return BadRequest("journalDetail is null");
            var updatedObject = await _serviceManager.journalDetailService.Update(journalDetail);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJournalDetail(int id)
        {
            var deletedObject = await _serviceManager.journalDetailService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                