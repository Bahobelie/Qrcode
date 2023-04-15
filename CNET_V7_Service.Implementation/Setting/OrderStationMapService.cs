
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
    public class OrderStationMapService : IOrderStationMapService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public OrderStationMapService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<OrderStationMapDTO>> Create(OrderStationMapDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<OrderStationMap>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.OrderStationMap.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<OrderStationMapDTO>(createdObj);
                
                //return response object

                return new ResponseModel<OrderStationMapDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<OrderStationMapDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<OrderStationMapDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.OrderStationMap.Delete(id);
                var returnedObj = _mapper.Map<OrderStationMapDTO>(res);
                return new ResponseModel<OrderStationMapDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<OrderStationMapDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<OrderStationMapDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.OrderStationMap.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<OrderStationMapDTO>>(result);
                return new ResponseModel<IEnumerable<OrderStationMapDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<OrderStationMapDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<OrderStationMapDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.OrderStationMap.FindById(id);
                var returnedObj = _mapper.Map<OrderStationMapDTO>(result);
                return new ResponseModel<OrderStationMapDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<OrderStationMapDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<OrderStationMapDTO>> Update(OrderStationMapDTO entity)
        {
            try
            {
                var account = _mapper.Map<OrderStationMap>(entity);
                var updatedObject = await _repository.OrderStationMap.Update(account);
                var returnedObj = _mapper.Map<OrderStationMapDTO>(updatedObject);
                return new ResponseModel<OrderStationMapDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<OrderStationMapDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            