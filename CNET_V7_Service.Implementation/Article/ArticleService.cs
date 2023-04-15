
using AutoMapper;
using CNET_V7_Domain.DataModels.ArticleSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.ArticleSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.ArticleSchema
{
    public class ArticleService : IArticleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ArticleService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ArticleDTO>> Create(ArticleDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Article>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Article.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ArticleDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ArticleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ArticleDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ArticleDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Article.Delete(id);
                var returnedObj = _mapper.Map<ArticleDTO>(res);
                return new ResponseModel<ArticleDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ArticleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ArticleDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Article.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ArticleDTO>>(result);
                return new ResponseModel<IEnumerable<ArticleDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ArticleDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ArticleDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Article.FindById(id);
                var returnedObj = _mapper.Map<ArticleDTO>(result);
                return new ResponseModel<ArticleDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ArticleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ArticleDTO>> Update(ArticleDTO entity)
        {
            try
            {
                var account = _mapper.Map<Article>(entity);
                var updatedObject = await _repository.Article.Update(account);
                var returnedObj = _mapper.Map<ArticleDTO>(updatedObject);
                return new ResponseModel<ArticleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ArticleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            