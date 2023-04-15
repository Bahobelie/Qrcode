
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
    public class EvaluationSheetController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public EvaluationSheetController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvaluationSheetById(int id)
        {
            var obj = await _serviceManager.evaluationSheetService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEvaluationSheets()
        {
            var accounts = await _serviceManager.evaluationSheetService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvaluationSheet([FromBody] EvaluationSheetDTO evaluationSheet)
        {
            if (evaluationSheet is null)
                return BadRequest("evaluationSheet is null");

            var createdObj = await _serviceManager.evaluationSheetService.Create(evaluationSheet);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEvaluationSheet([FromBody] EvaluationSheetDTO evaluationSheet)
        {
            if (evaluationSheet is null) return BadRequest("evaluationSheet is null");
            var updatedObject = await _serviceManager.evaluationSheetService.Update(evaluationSheet);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvaluationSheet(int id)
        {
            var deletedObject = await _serviceManager.evaluationSheetService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                