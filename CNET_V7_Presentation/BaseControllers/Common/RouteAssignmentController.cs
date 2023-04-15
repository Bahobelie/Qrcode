
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
    public class RouteAssignmentController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public RouteAssignmentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRouteAssignmentById(int id)
        {
            var obj = await _serviceManager.routeAssignmentService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRouteAssignments()
        {
            var accounts = await _serviceManager.routeAssignmentService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRouteAssignment([FromBody] RouteAssignmentDTO routeAssignment)
        {
            if (routeAssignment is null)
                return BadRequest("routeAssignment is null");

            var createdObj = await _serviceManager.routeAssignmentService.Create(routeAssignment);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRouteAssignment([FromBody] RouteAssignmentDTO routeAssignment)
        {
            if (routeAssignment is null) return BadRequest("routeAssignment is null");
            var updatedObject = await _serviceManager.routeAssignmentService.Update(routeAssignment);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRouteAssignment(int id)
        {
            var deletedObject = await _serviceManager.routeAssignmentService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                