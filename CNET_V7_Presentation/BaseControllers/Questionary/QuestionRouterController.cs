
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
    public class QuestionRouterController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public QuestionRouterController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestionRouterById(int id)
        {
            var obj = await _serviceManager.questionRouterService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuestionRouters()
        {
            var accounts = await _serviceManager.questionRouterService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestionRouter([FromBody] QuestionRouterDTO questionRouter)
        {
            if (questionRouter is null)
                return BadRequest("questionRouter is null");

            var createdObj = await _serviceManager.questionRouterService.Create(questionRouter);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateQuestionRouter([FromBody] QuestionRouterDTO questionRouter)
        {
            if (questionRouter is null) return BadRequest("questionRouter is null");
            var updatedObject = await _serviceManager.questionRouterService.Update(questionRouter);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestionRouter(int id)
        {
            var deletedObject = await _serviceManager.questionRouterService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                