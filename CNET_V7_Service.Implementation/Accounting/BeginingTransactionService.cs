
using AutoMapper;
using CNET_V7_Domain.DataModels.AccountingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.AccountingSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.AccountingSchema
{
    public class BeginingTransactionService : IBeginingTransactionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BeginingTransactionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<BeginingTransactionDTO>> Create(BeginingTransactionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<BeginingTransaction>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.BeginingTransaction.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<BeginingTransactionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<BeginingTransactionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BeginingTransactionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BeginingTransactionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.BeginingTransaction.Delete(id);
                var returnedObj = _mapper.Map<BeginingTransactionDTO>(res);
                return new ResponseModel<BeginingTransactionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BeginingTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<BeginingTransactionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.BeginingTransaction.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<BeginingTransactionDTO>>(result);
                return new ResponseModel<IEnumerable<BeginingTransactionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<BeginingTransactionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BeginingTransactionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.BeginingTransaction.FindById(id);
                var returnedObj = _mapper.Map<BeginingTransactionDTO>(result);
                return new ResponseModel<BeginingTransactionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BeginingTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BeginingTransactionDTO>> Update(BeginingTransactionDTO entity)
        {
            try
            {
                var account = _mapper.Map<BeginingTransaction>(entity);
                var updatedObject = await _repository.BeginingTransaction.Update(account);
                var returnedObj = _mapper.Map<BeginingTransactionDTO>(updatedObject);
                return new ResponseModel<BeginingTransactionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BeginingTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            