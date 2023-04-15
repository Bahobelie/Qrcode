
using AutoMapper;
using CNET_V7_Domain.DataModels.HrmsSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.HrmsSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.HrmsSchema
{
    public class AttendanceLogService : IAttendanceLogService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AttendanceLogService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<AttendanceLogDTO>> Create(AttendanceLogDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<AttendanceLog>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.AttendanceLog.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<AttendanceLogDTO>(createdObj);
                
                //return response object

                return new ResponseModel<AttendanceLogDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AttendanceLogDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AttendanceLogDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.AttendanceLog.Delete(id);
                var returnedObj = _mapper.Map<AttendanceLogDTO>(res);
                return new ResponseModel<AttendanceLogDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AttendanceLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<AttendanceLogDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.AttendanceLog.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<AttendanceLogDTO>>(result);
                return new ResponseModel<IEnumerable<AttendanceLogDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<AttendanceLogDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AttendanceLogDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.AttendanceLog.FindById(id);
                var returnedObj = _mapper.Map<AttendanceLogDTO>(result);
                return new ResponseModel<AttendanceLogDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AttendanceLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AttendanceLogDTO>> Update(AttendanceLogDTO entity)
        {
            try
            {
                var account = _mapper.Map<AttendanceLog>(entity);
                var updatedObject = await _repository.AttendanceLog.Update(account);
                var returnedObj = _mapper.Map<AttendanceLogDTO>(updatedObject);
                return new ResponseModel<AttendanceLogDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AttendanceLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            