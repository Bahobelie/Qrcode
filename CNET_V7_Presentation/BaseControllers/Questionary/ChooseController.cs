
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
    public class ChooseController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ChooseController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetChooseById(int id)
        {
            var obj = await _serviceManager.chooseService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllChooses()
        {
            var accounts = await _serviceManager.chooseService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateChoose([FromBody] ChooseDTO choose)
        {
            if (choose is null)
                return BadRequest("choose is null");

            var createdObj = await _serviceManager.chooseService.Create(choose);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateChoose([FromBody] ChooseDTO choose)
        {
            if (choose is null) return BadRequest("choose is null");
            var updatedObject = await _serviceManager.chooseService.Update(choose);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChoose(int id)
        {
            var deletedObject = await _serviceManager.chooseService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                