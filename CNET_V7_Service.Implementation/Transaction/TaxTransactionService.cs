
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
    public class TaxTransactionService : ITaxTransactionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TaxTransactionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TaxTransactionDTO>> Create(TaxTransactionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<TaxTransaction>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.TaxTransaction.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<TaxTransactionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<TaxTransactionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TaxTransactionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TaxTransactionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.TaxTransaction.Delete(id);
                var returnedObj = _mapper.Map<TaxTransactionDTO>(res);
                return new ResponseModel<TaxTransactionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TaxTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<TaxTransactionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.TaxTransaction.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<TaxTransactionDTO>>(result);
                return new ResponseModel<IEnumerable<TaxTransactionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<TaxTransactionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TaxTransactionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.TaxTransaction.FindById(id);
                var returnedObj = _mapper.Map<TaxTransactionDTO>(result);
                return new ResponseModel<TaxTransactionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TaxTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TaxTransactionDTO>> Update(TaxTransactionDTO entity)
        {
            try
            {
                var account = _mapper.Map<TaxTransaction>(entity);
                var updatedObject = await _repository.TaxTransaction.Update(account);
                var returnedObj = _mapper.Map<TaxTransactionDTO>(updatedObject);
                return new ResponseModel<TaxTransactionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TaxTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            