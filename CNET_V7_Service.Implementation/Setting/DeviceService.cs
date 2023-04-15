
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
    public class DeviceService : IDeviceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DeviceService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<DeviceDTO>> Create(DeviceDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Device>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Device.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<DeviceDTO>(createdObj);
                
                //return response object

                return new ResponseModel<DeviceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DeviceDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DeviceDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Device.Delete(id);
                var returnedObj = _mapper.Map<DeviceDTO>(res);
                return new ResponseModel<DeviceDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DeviceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<DeviceDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Device.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<DeviceDTO>>(result);
                return new ResponseModel<IEnumerable<DeviceDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<DeviceDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DeviceDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Device.FindById(id);
                var returnedObj = _mapper.Map<DeviceDTO>(result);
                return new ResponseModel<DeviceDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DeviceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DeviceDTO>> Update(DeviceDTO entity)
        {
            try
            {
                var account = _mapper.Map<Device>(entity);
                var updatedObject = await _repository.Device.Update(account);
                var returnedObj = _mapper.Map<DeviceDTO>(updatedObject);
                return new ResponseModel<DeviceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DeviceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            