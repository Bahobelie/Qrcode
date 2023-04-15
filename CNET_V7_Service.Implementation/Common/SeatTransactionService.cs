
using AutoMapper;
using CNET_V7_Domain.DataModels.CommonSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.CommonSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.CommonSchema
{
    public class SeatTransactionService : ISeatTransactionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SeatTransactionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SeatTransactionDTO>> Create(SeatTransactionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<SeatTransaction>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.SeatTransaction.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<SeatTransactionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<SeatTransactionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SeatTransactionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SeatTransactionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.SeatTransaction.Delete(id);
                var returnedObj = _mapper.Map<SeatTransactionDTO>(res);
                return new ResponseModel<SeatTransactionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SeatTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<SeatTransactionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.SeatTransaction.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<SeatTransactionDTO>>(result);
                return new ResponseModel<IEnumerable<SeatTransactionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<SeatTransactionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SeatTransactionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.SeatTransaction.FindById(id);
                var returnedObj = _mapper.Map<SeatTransactionDTO>(result);
                return new ResponseModel<SeatTransactionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SeatTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SeatTransactionDTO>> Update(SeatTransactionDTO entity)
        {
            try
            {
                var account = _mapper.Map<SeatTransaction>(entity);
                var updatedObject = await _repository.SeatTransaction.Update(account);
                var returnedObj = _mapper.Map<SeatTransactionDTO>(updatedObject);
                return new ResponseModel<SeatTransactionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SeatTransactionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            