
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
    public class QuestionService : IQuestionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public QuestionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<QuestionDTO>> Create(QuestionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Question>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Question.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<QuestionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<QuestionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<QuestionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<QuestionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Question.Delete(id);
                var returnedObj = _mapper.Map<QuestionDTO>(res);
                return new ResponseModel<QuestionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<QuestionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<QuestionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Question.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<QuestionDTO>>(result);
                return new ResponseModel<IEnumerable<QuestionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<QuestionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<QuestionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Question.FindById(id);
                var returnedObj = _mapper.Map<QuestionDTO>(result);
                return new ResponseModel<QuestionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<QuestionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<QuestionDTO>> Update(QuestionDTO entity)
        {
            try
            {
                var account = _mapper.Map<Question>(entity);
                var updatedObject = await _repository.Question.Update(account);
                var returnedObj = _mapper.Map<QuestionDTO>(updatedObject);
                return new ResponseModel<QuestionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<QuestionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            