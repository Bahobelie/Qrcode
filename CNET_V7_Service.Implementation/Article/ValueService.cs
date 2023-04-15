
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
    public class ValueService : IValueService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ValueService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ValueDTO>> Create(ValueDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Value>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Value.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ValueDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ValueDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Value.Delete(id);
                var returnedObj = _mapper.Map<ValueDTO>(res);
                return new ResponseModel<ValueDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ValueDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Value.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ValueDTO>>(result);
                return new ResponseModel<IEnumerable<ValueDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ValueDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Value.FindById(id);
                var returnedObj = _mapper.Map<ValueDTO>(result);
                return new ResponseModel<ValueDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueDTO>> Update(ValueDTO entity)
        {
            try
            {
                var account = _mapper.Map<Value>(entity);
                var updatedObject = await _repository.Value.Update(account);
                var returnedObj = _mapper.Map<ValueDTO>(updatedObject);
                return new ResponseModel<ValueDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            