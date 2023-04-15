
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
    public class MenuDesignerController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public MenuDesignerController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuDesignerById(int id)
        {
            var obj = await _serviceManager.menuDesignerService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMenuDesigners()
        {
            var accounts = await _serviceManager.menuDesignerService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMenuDesigner([FromBody] MenuDesignerDTO menuDesigner)
        {
            if (menuDesigner is null)
                return BadRequest("menuDesigner is null");

            var createdObj = await _serviceManager.menuDesignerService.Create(menuDesigner);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMenuDesigner([FromBody] MenuDesignerDTO menuDesigner)
        {
            if (menuDesigner is null) return BadRequest("menuDesigner is null");
            var updatedObject = await _serviceManager.menuDesignerService.Update(menuDesigner);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuDesigner(int id)
        {
            var deletedObject = await _serviceManager.menuDesignerService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                