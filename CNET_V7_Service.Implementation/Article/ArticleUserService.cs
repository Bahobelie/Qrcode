
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
    public class ArticleUserService : IArticleUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ArticleUserService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ArticleUserDTO>> Create(ArticleUserDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ArticleUser>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ArticleUser.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ArticleUserDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ArticleUserDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ArticleUserDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ArticleUserDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ArticleUser.Delete(id);
                var returnedObj = _mapper.Map<ArticleUserDTO>(res);
                return new ResponseModel<ArticleUserDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ArticleUserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ArticleUserDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ArticleUser.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ArticleUserDTO>>(result);
                return new ResponseModel<IEnumerable<ArticleUserDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ArticleUserDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ArticleUserDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ArticleUser.FindById(id);
                var returnedObj = _mapper.Map<ArticleUserDTO>(result);
                return new ResponseModel<ArticleUserDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ArticleUserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ArticleUserDTO>> Update(ArticleUserDTO entity)
        {
            try
            {
                var account = _mapper.Map<ArticleUser>(entity);
                var updatedObject = await _repository.ArticleUser.Update(account);
                var returnedObj = _mapper.Map<ArticleUserDTO>(updatedObject);
                return new ResponseModel<ArticleUserDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ArticleUserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            