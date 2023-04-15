
using AutoMapper;
using CNET_V7_Domain.DataModels.TransactionSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.TransactionSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.TransactionSchema
{
    public class NonCashTransactionService : INonCashTransactionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public NonCashTransactionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<NonCashTransactionDTO>> Create(NonCashTransactionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<NonCashTransaction>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.NonCashTransaction.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<NonCashTransactionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<NonCashTransactionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<NonCashTransactionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<NonCashTransactionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.NonCashTransaction.Delete(id);
                var returnedObj = _mapper.Map<NonCashTransactionDTO>(res);
                return new ResponseModel<NonCashTransactionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<NonCashTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<NonCashTransactionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.NonCashTransaction.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<NonCashTransactionDTO>>(result);
                return new ResponseModel<IEnumerable<NonCashTransactionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<NonCashTransactionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<NonCashTransactionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.NonCashTransaction.FindById(id);
                var returnedObj = _mapper.Map<NonCashTransactionDTO>(result);
                return new ResponseModel<NonCashTransactionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<NonCashTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<NonCashTransactionDTO>> Update(NonCashTransactionDTO entity)
        {
            try
            {
                var account = _mapper.Map<NonCashTransaction>(entity);
                var updatedObject = await _repository.NonCashTransaction.Update(account);
                var returnedObj = _mapper.Map<NonCashTransactionDTO>(updatedObject);
                return new ResponseModel<NonCashTransactionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<NonCashTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            