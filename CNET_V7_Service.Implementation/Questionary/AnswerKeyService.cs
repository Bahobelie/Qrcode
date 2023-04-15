
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
    public class AnswerKeyService : IAnswerKeyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AnswerKeyService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<AnswerKeyDTO>> Create(AnswerKeyDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<AnswerKey>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.AnswerKey.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<AnswerKeyDTO>(createdObj);
                
                //return response object

                return new ResponseModel<AnswerKeyDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AnswerKeyDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AnswerKeyDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.AnswerKey.Delete(id);
                var returnedObj = _mapper.Map<AnswerKeyDTO>(res);
                return new ResponseModel<AnswerKeyDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AnswerKeyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<AnswerKeyDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.AnswerKey.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<AnswerKeyDTO>>(result);
                return new ResponseModel<IEnumerable<AnswerKeyDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<AnswerKeyDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AnswerKeyDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.AnswerKey.FindById(id);
                var returnedObj = _mapper.Map<AnswerKeyDTO>(result);
                return new ResponseModel<AnswerKeyDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AnswerKeyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AnswerKeyDTO>> Update(AnswerKeyDTO entity)
        {
            try
            {
                var account = _mapper.Map<AnswerKey>(entity);
                var updatedObject = await _repository.AnswerKey.Update(account);
                var returnedObj = _mapper.Map<AnswerKeyDTO>(updatedObject);
                return new ResponseModel<AnswerKeyDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AnswerKeyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            