
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
    public class VoucherConsigneeListController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public VoucherConsigneeListController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVoucherConsigneeListById(int id)
        {
            var obj = await _serviceManager.voucherConsigneeListService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVoucherConsigneeLists()
        {
            var accounts = await _serviceManager.voucherConsigneeListService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVoucherConsigneeList([FromBody] VoucherConsigneeListDTO voucherConsigneeList)
        {
            if (voucherConsigneeList is null)
                return BadRequest("voucherConsigneeList is null");

            var createdObj = await _serviceManager.voucherConsigneeListService.Create(voucherConsigneeList);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVoucherConsigneeList([FromBody] VoucherConsigneeListDTO voucherConsigneeList)
        {
            if (voucherConsigneeList is null) return BadRequest("voucherConsigneeList is null");
            var updatedObject = await _serviceManager.voucherConsigneeListService.Update(voucherConsigneeList);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherConsigneeList(int id)
        {
            var deletedObject = await _serviceManager.voucherConsigneeListService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                