
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
    public class ReportHistoryService : IReportHistoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReportHistoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ReportHistoryDTO>> Create(ReportHistoryDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ReportHistory>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ReportHistory.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ReportHistoryDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ReportHistoryDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReportHistoryDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReportHistoryDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ReportHistory.Delete(id);
                var returnedObj = _mapper.Map<ReportHistoryDTO>(res);
                return new ResponseModel<ReportHistoryDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReportHistoryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ReportHistoryDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ReportHistory.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ReportHistoryDTO>>(result);
                return new ResponseModel<IEnumerable<ReportHistoryDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ReportHistoryDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReportHistoryDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ReportHistory.FindById(id);
                var returnedObj = _mapper.Map<ReportHistoryDTO>(result);
                return new ResponseModel<ReportHistoryDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReportHistoryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReportHistoryDTO>> Update(ReportHistoryDTO entity)
        {
            try
            {
                var account = _mapper.Map<ReportHistory>(entity);
                var updatedObject = await _repository.ReportHistory.Update(account);
                var returnedObj = _mapper.Map<ReportHistoryDTO>(updatedObject);
                return new ResponseModel<ReportHistoryDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReportHistoryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            