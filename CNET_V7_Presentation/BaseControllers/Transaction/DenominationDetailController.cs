
using CNET_V7_Domain.DataModels.TransactionSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.TransactionSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.TransactionSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class DenominationDetailController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public DenominationDetailController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDenominationDetailById(int id)
        {
            var obj = await _serviceManager.denominationDetailService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDenominationDetails()
        {
            var accounts = await _serviceManager.denominationDetailService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDenominationDetail([FromBody] DenominationDetailDTO denominationDetail)
        {
            if (denominationDetail is null)
                return BadRequest("denominationDetail is null");

            var createdObj = await _serviceManager.denominationDetailService.Create(denominationDetail);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDenominationDetail([FromBody] DenominationDetailDTO denominationDetail)
        {
            if (denominationDetail is null) return BadRequest("denominationDetail is null");
            var updatedObject = await _serviceManager.denominationDetailService.Update(denominationDetail);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDenominationDetail(int id)
        {
            var deletedObject = await _serviceManager.denominationDetailService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                