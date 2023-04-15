
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
    public class ScheduleDetailController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ScheduleDetailController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetScheduleDetailById(int id)
        {
            var obj = await _serviceManager.scheduleDetailService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllScheduleDetails()
        {
            var accounts = await _serviceManager.scheduleDetailService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateScheduleDetail([FromBody] ScheduleDetailDTO scheduleDetail)
        {
            if (scheduleDetail is null)
                return BadRequest("scheduleDetail is null");

            var createdObj = await _serviceManager.scheduleDetailService.Create(scheduleDetail);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateScheduleDetail([FromBody] ScheduleDetailDTO scheduleDetail)
        {
            if (scheduleDetail is null) return BadRequest("scheduleDetail is null");
            var updatedObject = await _serviceManager.scheduleDetailService.Update(scheduleDetail);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScheduleDetail(int id)
        {
            var deletedObject = await _serviceManager.scheduleDetailService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                