
using CNET_V7_Domain.DataModels.SettingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.SettingSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.SettingSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderStationMapController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public OrderStationMapController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderStationMapById(int id)
        {
            var obj = await _serviceManager.orderStationMapService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrderStationMaps()
        {
            var accounts = await _serviceManager.orderStationMapService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderStationMap([FromBody] OrderStationMapDTO orderStationMap)
        {
            if (orderStationMap is null)
                return BadRequest("orderStationMap is null");

            var createdObj = await _serviceManager.orderStationMapService.Create(orderStationMap);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrderStationMap([FromBody] OrderStationMapDTO orderStationMap)
        {
            if (orderStationMap is null) return BadRequest("orderStationMap is null");
            var updatedObject = await _serviceManager.orderStationMapService.Update(orderStationMap);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderStationMap(int id)
        {
            var deletedObject = await _serviceManager.orderStationMapService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                