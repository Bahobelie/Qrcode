
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
    public class GsluserController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public GsluserController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGsluserById(int id)
        {
            var obj = await _serviceManager.gsluserService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGslusers()
        {
            var accounts = await _serviceManager.gsluserService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGsluser([FromBody] GsluserDTO gsluser)
        {
            if (gsluser is null)
                return BadRequest("gsluser is null");

            var createdObj = await _serviceManager.gsluserService.Create(gsluser);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGsluser([FromBody] GsluserDTO gsluser)
        {
            if (gsluser is null) return BadRequest("gsluser is null");
            var updatedObject = await _serviceManager.gsluserService.Update(gsluser);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGsluser(int id)
        {
            var deletedObject = await _serviceManager.gsluserService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                