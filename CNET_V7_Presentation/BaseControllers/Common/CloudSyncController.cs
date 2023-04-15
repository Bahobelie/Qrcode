
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
    public class CloudSyncController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public CloudSyncController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCloudSyncById(int id)
        {
            var obj = await _serviceManager.cloudSyncService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCloudSyncs()
        {
            var accounts = await _serviceManager.cloudSyncService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCloudSync([FromBody] CloudSyncDTO cloudSync)
        {
            if (cloudSync is null)
                return BadRequest("cloudSync is null");

            var createdObj = await _serviceManager.cloudSyncService.Create(cloudSync);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCloudSync([FromBody] CloudSyncDTO cloudSync)
        {
            if (cloudSync is null) return BadRequest("cloudSync is null");
            var updatedObject = await _serviceManager.cloudSyncService.Update(cloudSync);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCloudSync(int id)
        {
            var deletedObject = await _serviceManager.cloudSyncService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                