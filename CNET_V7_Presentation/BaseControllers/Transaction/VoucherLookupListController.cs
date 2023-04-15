
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
    public class VoucherLookupListController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public VoucherLookupListController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVoucherLookupListById(int id)
        {
            var obj = await _serviceManager.voucherLookupListService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVoucherLookupLists()
        {
            var accounts = await _serviceManager.voucherLookupListService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVoucherLookupList([FromBody] VoucherLookupListDTO voucherLookupList)
        {
            if (voucherLookupList is null)
                return BadRequest("voucherLookupList is null");

            var createdObj = await _serviceManager.voucherLookupListService.Create(voucherLookupList);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVoucherLookupList([FromBody] VoucherLookupListDTO voucherLookupList)
        {
            if (voucherLookupList is null) return BadRequest("voucherLookupList is null");
            var updatedObject = await _serviceManager.voucherLookupListService.Update(voucherLookupList);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherLookupList(int id)
        {
            var deletedObject = await _serviceManager.voucherLookupListService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                