
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
    public class TransactionCurrencyService : ITransactionCurrencyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TransactionCurrencyService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TransactionCurrencyDTO>> Create(TransactionCurrencyDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<TransactionCurrency>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.TransactionCurrency.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<TransactionCurrencyDTO>(createdObj);
                
                //return response object

                return new ResponseModel<TransactionCurrencyDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionCurrencyDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionCurrencyDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.TransactionCurrency.Delete(id);
                var returnedObj = _mapper.Map<TransactionCurrencyDTO>(res);
                return new ResponseModel<TransactionCurrencyDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionCurrencyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<TransactionCurrencyDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.TransactionCurrency.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<TransactionCurrencyDTO>>(result);
                return new ResponseModel<IEnumerable<TransactionCurrencyDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<TransactionCurrencyDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionCurrencyDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.TransactionCurrency.FindById(id);
                var returnedObj = _mapper.Map<TransactionCurrencyDTO>(result);
                return new ResponseModel<TransactionCurrencyDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionCurrencyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionCurrencyDTO>> Update(TransactionCurrencyDTO entity)
        {
            try
            {
                var account = _mapper.Map<TransactionCurrency>(entity);
                var updatedObject = await _repository.TransactionCurrency.Update(account);
                var returnedObj = _mapper.Map<TransactionCurrencyDTO>(updatedObject);
                return new ResponseModel<TransactionCurrencyDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionCurrencyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            