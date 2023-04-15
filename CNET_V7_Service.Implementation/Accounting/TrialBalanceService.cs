
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
    public class TrialBalanceService : ITrialBalanceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TrialBalanceService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TrialBalanceDTO>> Create(TrialBalanceDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<TrialBalance>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.TrialBalance.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<TrialBalanceDTO>(createdObj);
                
                //return response object

                return new ResponseModel<TrialBalanceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TrialBalanceDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TrialBalanceDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.TrialBalance.Delete(id);
                var returnedObj = _mapper.Map<TrialBalanceDTO>(res);
                return new ResponseModel<TrialBalanceDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TrialBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<TrialBalanceDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.TrialBalance.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<TrialBalanceDTO>>(result);
                return new ResponseModel<IEnumerable<TrialBalanceDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<TrialBalanceDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TrialBalanceDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.TrialBalance.FindById(id);
                var returnedObj = _mapper.Map<TrialBalanceDTO>(result);
                return new ResponseModel<TrialBalanceDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TrialBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TrialBalanceDTO>> Update(TrialBalanceDTO entity)
        {
            try
            {
                var account = _mapper.Map<TrialBalance>(entity);
                var updatedObject = await _repository.TrialBalance.Update(account);
                var returnedObj = _mapper.Map<TrialBalanceDTO>(updatedObject);
                return new ResponseModel<TrialBalanceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TrialBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            