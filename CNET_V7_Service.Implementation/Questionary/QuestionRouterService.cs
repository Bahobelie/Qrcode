
using AutoMapper;
using CNET_V7_Domain.DataModels.QuestionarySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.QuestionarySchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.QuestionarySchema
{
    public class QuestionRouterService : IQuestionRouterService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public QuestionRouterService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<QuestionRouterDTO>> Create(QuestionRouterDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<QuestionRouter>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.QuestionRouter.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<QuestionRouterDTO>(createdObj);
                
                //return response object

                return new ResponseModel<QuestionRouterDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<QuestionRouterDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<QuestionRouterDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.QuestionRouter.Delete(id);
                var returnedObj = _mapper.Map<QuestionRouterDTO>(res);
                return new ResponseModel<QuestionRouterDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<QuestionRouterDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<QuestionRouterDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.QuestionRouter.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<QuestionRouterDTO>>(result);
                return new ResponseModel<IEnumerable<QuestionRouterDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<QuestionRouterDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<QuestionRouterDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.QuestionRouter.FindById(id);
                var returnedObj = _mapper.Map<QuestionRouterDTO>(result);
                return new ResponseModel<QuestionRouterDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<QuestionRouterDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<QuestionRouterDTO>> Update(QuestionRouterDTO entity)
        {
            try
            {
                var account = _mapper.Map<QuestionRouter>(entity);
                var updatedObject = await _repository.QuestionRouter.Update(account);
                var returnedObj = _mapper.Map<QuestionRouterDTO>(updatedObject);
                return new ResponseModel<QuestionRouterDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<QuestionRouterDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            