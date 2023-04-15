
using CNET_V7_Domain.DataModels.ArticleSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ArticleSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ArticleSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValueChangeLogController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ValueChangeLogController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValueChangeLogById(int id)
        {
            var obj = await _serviceManager.valueChangeLogService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllValueChangeLogs()
        {
            var accounts = await _serviceManager.valueChangeLogService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateValueChangeLog([FromBody] ValueChangeLogDTO valueChangeLog)
        {
            if (valueChangeLog is null)
                return BadRequest("valueChangeLog is null");

            var createdObj = await _serviceManager.valueChangeLogService.Create(valueChangeLog);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateValueChangeLog([FromBody] ValueChangeLogDTO valueChangeLog)
        {
            if (valueChangeLog is null) return BadRequest("valueChangeLog is null");
            var updatedObject = await _serviceManager.valueChangeLogService.Update(valueChangeLog);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteValueChangeLog(int id)
        {
            var deletedObject = await _serviceManager.valueChangeLogService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                