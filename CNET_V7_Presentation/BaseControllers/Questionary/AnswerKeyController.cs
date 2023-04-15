
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
    public class AnswerKeyController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public AnswerKeyController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnswerKeyById(int id)
        {
            var obj = await _serviceManager.answerKeyService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAnswerKeys()
        {
            var accounts = await _serviceManager.answerKeyService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnswerKey([FromBody] AnswerKeyDTO answerKey)
        {
            if (answerKey is null)
                return BadRequest("answerKey is null");

            var createdObj = await _serviceManager.answerKeyService.Create(answerKey);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAnswerKey([FromBody] AnswerKeyDTO answerKey)
        {
            if (answerKey is null) return BadRequest("answerKey is null");
            var updatedObject = await _serviceManager.answerKeyService.Update(answerKey);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnswerKey(int id)
        {
            var deletedObject = await _serviceManager.answerKeyService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                