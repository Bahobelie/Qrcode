
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
    public class DelegateController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public DelegateController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDelegateById(int id)
        {
            var obj = await _serviceManager.delegateService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDelegates()
        {
            var accounts = await _serviceManager.delegateService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDelegate([FromBody] DelegateDTO delegateObj)
        {
            if (delegateObj is null)
                return BadRequest("delegate is null");

            var createdObj = await _serviceManager.delegateService.Create(delegateObj);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDelegate([FromBody] DelegateDTO delegateObj)
        {
            if (delegateObj is null) return BadRequest("delegate is null");
            var updatedObject = await _serviceManager.delegateService.Update(delegateObj);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDelegate(int id)
        {
            var deletedObject = await _serviceManager.delegateService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                