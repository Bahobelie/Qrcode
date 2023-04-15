
using AutoMapper;
using CNET_V7_Domain.DataModels.SettingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.SettingSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.SettingSchema
{
    public class ReconciliationSummaryService : IReconciliationSummaryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReconciliationSummaryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ReconciliationSummaryDTO>> Create(ReconciliationSummaryDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ReconciliationSummary>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ReconciliationSummary.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ReconciliationSummaryDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ReconciliationSummaryDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReconciliationSummaryDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReconciliationSummaryDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ReconciliationSummary.Delete(id);
                var returnedObj = _mapper.Map<ReconciliationSummaryDTO>(res);
                return new ResponseModel<ReconciliationSummaryDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReconciliationSummaryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ReconciliationSummaryDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ReconciliationSummary.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ReconciliationSummaryDTO>>(result);
                return new ResponseModel<IEnumerable<ReconciliationSummaryDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ReconciliationSummaryDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReconciliationSummaryDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ReconciliationSummary.FindById(id);
                var returnedObj = _mapper.Map<ReconciliationSummaryDTO>(result);
                return new ResponseModel<ReconciliationSummaryDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReconciliationSummaryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReconciliationSummaryDTO>> Update(ReconciliationSummaryDTO entity)
        {
            try
            {
                var account = _mapper.Map<ReconciliationSummary>(entity);
                var updatedObject = await _repository.ReconciliationSummary.Update(account);
                var returnedObj = _mapper.Map<ReconciliationSummaryDTO>(updatedObject);
                return new ResponseModel<ReconciliationSummaryDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReconciliationSummaryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            