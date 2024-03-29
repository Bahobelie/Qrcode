
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
    public class ValueChangeLogService : IValueChangeLogService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ValueChangeLogService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ValueChangeLogDTO>> Create(ValueChangeLogDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ValueChangeLog>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ValueChangeLog.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ValueChangeLogDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ValueChangeLogDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueChangeLogDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueChangeLogDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ValueChangeLog.Delete(id);
                var returnedObj = _mapper.Map<ValueChangeLogDTO>(res);
                return new ResponseModel<ValueChangeLogDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueChangeLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ValueChangeLogDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ValueChangeLog.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ValueChangeLogDTO>>(result);
                return new ResponseModel<IEnumerable<ValueChangeLogDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ValueChangeLogDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueChangeLogDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ValueChangeLog.FindById(id);
                var returnedObj = _mapper.Map<ValueChangeLogDTO>(result);
                return new ResponseModel<ValueChangeLogDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueChangeLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueChangeLogDTO>> Update(ValueChangeLogDTO entity)
        {
            try
            {
                var account = _mapper.Map<ValueChangeLog>(entity);
                var updatedObject = await _repository.ValueChangeLog.Update(account);
                var returnedObj = _mapper.Map<ValueChangeLogDTO>(updatedObject);
                return new ResponseModel<ValueChangeLogDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueChangeLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            