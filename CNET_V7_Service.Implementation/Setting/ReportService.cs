
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
    public class ReportService : IReportService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReportService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ReportDTO>> Create(ReportDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Report>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Report.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ReportDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ReportDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReportDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReportDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Report.Delete(id);
                var returnedObj = _mapper.Map<ReportDTO>(res);
                return new ResponseModel<ReportDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReportDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ReportDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Report.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ReportDTO>>(result);
                return new ResponseModel<IEnumerable<ReportDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ReportDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReportDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Report.FindById(id);
                var returnedObj = _mapper.Map<ReportDTO>(result);
                return new ResponseModel<ReportDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReportDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReportDTO>> Update(ReportDTO entity)
        {
            try
            {
                var account = _mapper.Map<Report>(entity);
                var updatedObject = await _repository.Report.Update(account);
                var returnedObj = _mapper.Map<ReportDTO>(updatedObject);
                return new ResponseModel<ReportDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReportDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            