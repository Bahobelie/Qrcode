
using CNET_V7_Domain.DataModels.ArticleSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ArticleSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ArticleSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ArticleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleById(int id)
        {
            var obj = await _serviceManager.articleService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticles()
        {
            var accounts = await _serviceManager.articleService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle([FromBody] ArticleDTO article)
        {
            if (article is null)
                return BadRequest("article is null");

            var createdObj = await _serviceManager.articleService.Create(article);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArticle([FromBody] ArticleDTO article)
        {
            if (article is null) return BadRequest("article is null");
            var updatedObject = await _serviceManager.articleService.Update(article);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var deletedObject = await _serviceManager.articleService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                