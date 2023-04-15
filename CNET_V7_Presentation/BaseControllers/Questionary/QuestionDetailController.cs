
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
    public class QuestionDetailController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public QuestionDetailController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestionDetailById(int id)
        {
            var obj = await _serviceManager.questionDetailService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuestionDetails()
        {
            var accounts = await _serviceManager.questionDetailService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestionDetail([FromBody] QuestionDetailDTO questionDetail)
        {
            if (questionDetail is null)
                return BadRequest("questionDetail is null");

            var createdObj = await _serviceManager.questionDetailService.Create(questionDetail);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateQuestionDetail([FromBody] QuestionDetailDTO questionDetail)
        {
            if (questionDetail is null) return BadRequest("questionDetail is null");
            var updatedObject = await _serviceManager.questionDetailService.Update(questionDetail);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestionDetail(int id)
        {
            var deletedObject = await _serviceManager.questionDetailService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                