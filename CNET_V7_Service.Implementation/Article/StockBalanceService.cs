
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
    public class StockBalanceService : IStockBalanceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StockBalanceService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<StockBalanceDTO>> Create(StockBalanceDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<StockBalance>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.StockBalance.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<StockBalanceDTO>(createdObj);
                
                //return response object

                return new ResponseModel<StockBalanceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<StockBalanceDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<StockBalanceDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.StockBalance.Delete(id);
                var returnedObj = _mapper.Map<StockBalanceDTO>(res);
                return new ResponseModel<StockBalanceDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<StockBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<StockBalanceDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.StockBalance.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<StockBalanceDTO>>(result);
                return new ResponseModel<IEnumerable<StockBalanceDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<StockBalanceDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<StockBalanceDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.StockBalance.FindById(id);
                var returnedObj = _mapper.Map<StockBalanceDTO>(result);
                return new ResponseModel<StockBalanceDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<StockBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<StockBalanceDTO>> Update(StockBalanceDTO entity)
        {
            try
            {
                var account = _mapper.Map<StockBalance>(entity);
                var updatedObject = await _repository.StockBalance.Update(account);
                var returnedObj = _mapper.Map<StockBalanceDTO>(updatedObject);
                return new ResponseModel<StockBalanceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<StockBalanceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            