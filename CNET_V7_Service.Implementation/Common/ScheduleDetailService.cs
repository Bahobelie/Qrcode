
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
    public class ScheduleDetailService : IScheduleDetailService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ScheduleDetailService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ScheduleDetailDTO>> Create(ScheduleDetailDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ScheduleDetail>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ScheduleDetail.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ScheduleDetailDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ScheduleDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleDetailDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleDetailDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ScheduleDetail.Delete(id);
                var returnedObj = _mapper.Map<ScheduleDetailDTO>(res);
                return new ResponseModel<ScheduleDetailDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ScheduleDetailDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ScheduleDetail.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ScheduleDetailDTO>>(result);
                return new ResponseModel<IEnumerable<ScheduleDetailDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ScheduleDetailDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleDetailDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ScheduleDetail.FindById(id);
                var returnedObj = _mapper.Map<ScheduleDetailDTO>(result);
                return new ResponseModel<ScheduleDetailDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleDetailDTO>> Update(ScheduleDetailDTO entity)
        {
            try
            {
                var account = _mapper.Map<ScheduleDetail>(entity);
                var updatedObject = await _repository.ScheduleDetail.Update(account);
                var returnedObj = _mapper.Map<ScheduleDetailDTO>(updatedObject);
                return new ResponseModel<ScheduleDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            