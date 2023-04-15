
using AutoMapper;
using CNET_V7_Domain.DataModels.ConsigneeSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.ConsigneeSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.ConsigneeSchema
{
    public class TransactionLimitService : ITransactionLimitService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TransactionLimitService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TransactionLimitDTO>> Create(TransactionLimitDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<TransactionLimit>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.TransactionLimit.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<TransactionLimitDTO>(createdObj);
                
                //return response object

                return new ResponseModel<TransactionLimitDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionLimitDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionLimitDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.TransactionLimit.Delete(id);
                var returnedObj = _mapper.Map<TransactionLimitDTO>(res);
                return new ResponseModel<TransactionLimitDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionLimitDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<TransactionLimitDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.TransactionLimit.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<TransactionLimitDTO>>(result);
                return new ResponseModel<IEnumerable<TransactionLimitDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<TransactionLimitDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionLimitDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.TransactionLimit.FindById(id);
                var returnedObj = _mapper.Map<TransactionLimitDTO>(result);
                return new ResponseModel<TransactionLimitDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionLimitDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionLimitDTO>> Update(TransactionLimitDTO entity)
        {
            try
            {
                var account = _mapper.Map<TransactionLimit>(entity);
                var updatedObject = await _repository.TransactionLimit.Update(account);
                var returnedObj = _mapper.Map<TransactionLimitDTO>(updatedObject);
                return new ResponseModel<TransactionLimitDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionLimitDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            