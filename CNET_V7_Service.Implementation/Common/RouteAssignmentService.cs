
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
    public class RouteAssignmentService : IRouteAssignmentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RouteAssignmentService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<RouteAssignmentDTO>> Create(RouteAssignmentDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<RouteAssignment>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.RouteAssignment.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<RouteAssignmentDTO>(createdObj);
                
                //return response object

                return new ResponseModel<RouteAssignmentDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RouteAssignmentDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RouteAssignmentDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.RouteAssignment.Delete(id);
                var returnedObj = _mapper.Map<RouteAssignmentDTO>(res);
                return new ResponseModel<RouteAssignmentDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RouteAssignmentDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<RouteAssignmentDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.RouteAssignment.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<RouteAssignmentDTO>>(result);
                return new ResponseModel<IEnumerable<RouteAssignmentDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<RouteAssignmentDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RouteAssignmentDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.RouteAssignment.FindById(id);
                var returnedObj = _mapper.Map<RouteAssignmentDTO>(result);
                return new ResponseModel<RouteAssignmentDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RouteAssignmentDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RouteAssignmentDTO>> Update(RouteAssignmentDTO entity)
        {
            try
            {
                var account = _mapper.Map<RouteAssignment>(entity);
                var updatedObject = await _repository.RouteAssignment.Update(account);
                var returnedObj = _mapper.Map<RouteAssignmentDTO>(updatedObject);
                return new ResponseModel<RouteAssignmentDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RouteAssignmentDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            