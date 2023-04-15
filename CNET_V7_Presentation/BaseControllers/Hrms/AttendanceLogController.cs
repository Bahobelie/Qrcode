
using CNET_V7_Domain.DataModels.HrmsSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.HrmsSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.HrmsSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceLogController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public AttendanceLogController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttendanceLogById(int id)
        {
            var obj = await _serviceManager.attendanceLogService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAttendanceLogs()
        {
            var accounts = await _serviceManager.attendanceLogService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttendanceLog([FromBody] AttendanceLogDTO attendanceLog)
        {
            if (attendanceLog is null)
                return BadRequest("attendanceLog is null");

            var createdObj = await _serviceManager.attendanceLogService.Create(attendanceLog);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAttendanceLog([FromBody] AttendanceLogDTO attendanceLog)
        {
            if (attendanceLog is null) return BadRequest("attendanceLog is null");
            var updatedObject = await _serviceManager.attendanceLogService.Update(attendanceLog);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttendanceLog(int id)
        {
            var deletedObject = await _serviceManager.attendanceLogService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                