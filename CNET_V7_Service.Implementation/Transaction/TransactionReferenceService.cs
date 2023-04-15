
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
    public class TransactionReferenceService : ITransactionReferenceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TransactionReferenceService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TransactionReferenceDTO>> Create(TransactionReferenceDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<TransactionReference>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.TransactionReference.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<TransactionReferenceDTO>(createdObj);
                
                //return response object

                return new ResponseModel<TransactionReferenceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionReferenceDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionReferenceDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.TransactionReference.Delete(id);
                var returnedObj = _mapper.Map<TransactionReferenceDTO>(res);
                return new ResponseModel<TransactionReferenceDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionReferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<TransactionReferenceDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.TransactionReference.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<TransactionReferenceDTO>>(result);
                return new ResponseModel<IEnumerable<TransactionReferenceDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<TransactionReferenceDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionReferenceDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.TransactionReference.FindById(id);
                var returnedObj = _mapper.Map<TransactionReferenceDTO>(result);
                return new ResponseModel<TransactionReferenceDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionReferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TransactionReferenceDTO>> Update(TransactionReferenceDTO entity)
        {
            try
            {
                var account = _mapper.Map<TransactionReference>(entity);
                var updatedObject = await _repository.TransactionReference.Update(account);
                var returnedObj = _mapper.Map<TransactionReferenceDTO>(updatedObject);
                return new ResponseModel<TransactionReferenceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TransactionReferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            