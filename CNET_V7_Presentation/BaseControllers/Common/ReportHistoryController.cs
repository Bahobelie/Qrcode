
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
    public class ReportHistoryController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ReportHistoryController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReportHistoryById(int id)
        {
            var obj = await _serviceManager.reportHistoryService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReportHistorys()
        {
            var accounts = await _serviceManager.reportHistoryService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReportHistory([FromBody] ReportHistoryDTO reportHistory)
        {
            if (reportHistory is null)
                return BadRequest("reportHistory is null");

            var createdObj = await _serviceManager.reportHistoryService.Create(reportHistory);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReportHistory([FromBody] ReportHistoryDTO reportHistory)
        {
            if (reportHistory is null) return BadRequest("reportHistory is null");
            var updatedObject = await _serviceManager.reportHistoryService.Update(reportHistory);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReportHistory(int id)
        {
            var deletedObject = await _serviceManager.reportHistoryService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                