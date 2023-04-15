
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
    public class BeginingBalanceService : IBeginingBalanceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BeginingBalanceService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<BeginingBalanceDTO>> Create(BeginingBalanceDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<BeginingBalance>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.BeginingBalance.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<BeginingBalanceDTO>(createdObj);
                
                //return response object

                return new ResponseModel<BeginingBalanceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BeginingBalanceDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BeginingBalanceDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.BeginingBalance.Delete(id);
                var returnedObj = _mapper.Map<BeginingBalanceDTO>(res);
                return new ResponseModel<BeginingBalanceDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BeginingBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<BeginingBalanceDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.BeginingBalance.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<BeginingBalanceDTO>>(result);
                return new ResponseModel<IEnumerable<BeginingBalanceDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<BeginingBalanceDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BeginingBalanceDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.BeginingBalance.FindById(id);
                var returnedObj = _mapper.Map<BeginingBalanceDTO>(result);
                return new ResponseModel<BeginingBalanceDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BeginingBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BeginingBalanceDTO>> Update(BeginingBalanceDTO entity)
        {
            try
            {
                var account = _mapper.Map<BeginingBalance>(entity);
                var updatedObject = await _repository.BeginingBalance.Update(account);
                var returnedObj = _mapper.Map<BeginingBalanceDTO>(updatedObject);
                return new ResponseModel<BeginingBalanceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BeginingBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            