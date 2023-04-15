
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
    public class StockLevelService : IStockLevelService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StockLevelService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<StockLevelDTO>> Create(StockLevelDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<StockLevel>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.StockLevel.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<StockLevelDTO>(createdObj);
                
                //return response object

                return new ResponseModel<StockLevelDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<StockLevelDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<StockLevelDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.StockLevel.Delete(id);
                var returnedObj = _mapper.Map<StockLevelDTO>(res);
                return new ResponseModel<StockLevelDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<StockLevelDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<StockLevelDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.StockLevel.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<StockLevelDTO>>(result);
                return new ResponseModel<IEnumerable<StockLevelDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<StockLevelDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<StockLevelDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.StockLevel.FindById(id);
                var returnedObj = _mapper.Map<StockLevelDTO>(result);
                return new ResponseModel<StockLevelDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<StockLevelDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<StockLevelDTO>> Update(StockLevelDTO entity)
        {
            try
            {
                var account = _mapper.Map<StockLevel>(entity);
                var updatedObject = await _repository.StockLevel.Update(account);
                var returnedObj = _mapper.Map<StockLevelDTO>(updatedObject);
                return new ResponseModel<StockLevelDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<StockLevelDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            