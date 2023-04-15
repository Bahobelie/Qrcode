
using CNET_V7_Domain.DataModels.SecuritySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.SecuritySchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.SecuritySchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class AccessMatrixController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public AccessMatrixController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccessMatrixById(int id)
        {
            var obj = await _serviceManager.accessMatrixService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAccessMatrixs()
        {
            var accounts = await _serviceManager.accessMatrixService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccessMatrix([FromBody] AccessMatrixDTO accessMatrix)
        {
            if (accessMatrix is null)
                return BadRequest("accessMatrix is null");

            var createdObj = await _serviceManager.accessMatrixService.Create(accessMatrix);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAccessMatrix([FromBody] AccessMatrixDTO accessMatrix)
        {
            if (accessMatrix is null) return BadRequest("accessMatrix is null");
            var updatedObject = await _serviceManager.accessMatrixService.Update(accessMatrix);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccessMatrix(int id)
        {
            var deletedObject = await _serviceManager.accessMatrixService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                