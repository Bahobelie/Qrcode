
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
    public class RouteService : IRouteService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RouteService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<RouteDTO>> Create(RouteDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<CNET_V7_Entities.DataModels.Route>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Route.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<RouteDTO>(createdObj);
                
                //return response object

                return new ResponseModel<RouteDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RouteDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RouteDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Route.Delete(id);
                var returnedObj = _mapper.Map<RouteDTO>(res);
                return new ResponseModel<RouteDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RouteDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<RouteDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Route.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<RouteDTO>>(result);
                return new ResponseModel<IEnumerable<RouteDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<RouteDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RouteDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Route.FindById(id);
                var returnedObj = _mapper.Map<RouteDTO>(result);
                return new ResponseModel<RouteDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RouteDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RouteDTO>> Update(RouteDTO entity)
        {
            try
            {
                var account = _mapper.Map<CNET_V7_Entities.DataModels.Route>(entity);
                var updatedObject = await _repository.Route.Update(account);
                var returnedObj = _mapper.Map<RouteDTO>(updatedObject);
                return new ResponseModel<RouteDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RouteDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            