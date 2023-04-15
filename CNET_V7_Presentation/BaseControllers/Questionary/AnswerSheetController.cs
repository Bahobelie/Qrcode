
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
    public class AnswerSheetController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public AnswerSheetController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnswerSheetById(int id)
        {
            var obj = await _serviceManager.answerSheetService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAnswerSheets()
        {
            var accounts = await _serviceManager.answerSheetService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnswerSheet([FromBody] AnswerSheetDTO answerSheet)
        {
            if (answerSheet is null)
                return BadRequest("answerSheet is null");

            var createdObj = await _serviceManager.answerSheetService.Create(answerSheet);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAnswerSheet([FromBody] AnswerSheetDTO answerSheet)
        {
            if (answerSheet is null) return BadRequest("answerSheet is null");
            var updatedObject = await _serviceManager.answerSheetService.Update(answerSheet);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnswerSheet(int id)
        {
            var deletedObject = await _serviceManager.answerSheetService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                