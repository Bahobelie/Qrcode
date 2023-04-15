
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
    public class ScheduleHeaderController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ScheduleHeaderController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetScheduleHeaderById(int id)
        {
            var obj = await _serviceManager.scheduleHeaderService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllScheduleHeaders()
        {
            var accounts = await _serviceManager.scheduleHeaderService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateScheduleHeader([FromBody] ScheduleHeaderDTO scheduleHeader)
        {
            if (scheduleHeader is null)
                return BadRequest("scheduleHeader is null");

            var createdObj = await _serviceManager.scheduleHeaderService.Create(scheduleHeader);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateScheduleHeader([FromBody] ScheduleHeaderDTO scheduleHeader)
        {
            if (scheduleHeader is null) return BadRequest("scheduleHeader is null");
            var updatedObject = await _serviceManager.scheduleHeaderService.Update(scheduleHeader);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScheduleHeader(int id)
        {
            var deletedObject = await _serviceManager.scheduleHeaderService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                