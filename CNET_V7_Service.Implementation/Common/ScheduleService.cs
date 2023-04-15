
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
    public class ScheduleService : IScheduleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ScheduleService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ScheduleDTO>> Create(ScheduleDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Schedule>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Schedule.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ScheduleDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ScheduleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Schedule.Delete(id);
                var returnedObj = _mapper.Map<ScheduleDTO>(res);
                return new ResponseModel<ScheduleDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ScheduleDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Schedule.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ScheduleDTO>>(result);
                return new ResponseModel<IEnumerable<ScheduleDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ScheduleDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Schedule.FindById(id);
                var returnedObj = _mapper.Map<ScheduleDTO>(result);
                return new ResponseModel<ScheduleDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleDTO>> Update(ScheduleDTO entity)
        {
            try
            {
                var account = _mapper.Map<Schedule>(entity);
                var updatedObject = await _repository.Schedule.Update(account);
                var returnedObj = _mapper.Map<ScheduleDTO>(updatedObject);
                return new ResponseModel<ScheduleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            