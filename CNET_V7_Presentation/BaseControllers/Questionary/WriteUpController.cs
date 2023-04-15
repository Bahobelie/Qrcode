
using CNET_V7_Domain.DataModels.QuestionarySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.QuestionarySchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.QuestionarySchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class WriteUpController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public WriteUpController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWriteUpById(int id)
        {
            var obj = await _serviceManager.writeUpService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWriteUps()
        {
            var accounts = await _serviceManager.writeUpService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWriteUp([FromBody] WriteUpDTO writeUp)
        {
            if (writeUp is null)
                return BadRequest("writeUp is null");

            var createdObj = await _serviceManager.writeUpService.Create(writeUp);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWriteUp([FromBody] WriteUpDTO writeUp)
        {
            if (writeUp is null) return BadRequest("writeUp is null");
            var updatedObject = await _serviceManager.writeUpService.Update(writeUp);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWriteUp(int id)
        {
            var deletedObject = await _serviceManager.writeUpService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                