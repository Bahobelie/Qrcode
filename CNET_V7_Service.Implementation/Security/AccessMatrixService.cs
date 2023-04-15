
using AutoMapper;
using CNET_V7_Domain.DataModels.SecuritySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.SecuritySchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.SecuritySchema
{
    public class AccessMatrixService : IAccessMatrixService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AccessMatrixService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<AccessMatrixDTO>> Create(AccessMatrixDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<AccessMatrix>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.AccessMatrix.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<AccessMatrixDTO>(createdObj);
                
                //return response object

                return new ResponseModel<AccessMatrixDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccessMatrixDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccessMatrixDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.AccessMatrix.Delete(id);
                var returnedObj = _mapper.Map<AccessMatrixDTO>(res);
                return new ResponseModel<AccessMatrixDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccessMatrixDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<AccessMatrixDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.AccessMatrix.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<AccessMatrixDTO>>(result);
                return new ResponseModel<IEnumerable<AccessMatrixDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<AccessMatrixDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccessMatrixDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.AccessMatrix.FindById(id);
                var returnedObj = _mapper.Map<AccessMatrixDTO>(result);
                return new ResponseModel<AccessMatrixDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccessMatrixDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccessMatrixDTO>> Update(AccessMatrixDTO entity)
        {
            try
            {
                var account = _mapper.Map<AccessMatrix>(entity);
                var updatedObject = await _repository.AccessMatrix.Update(account);
                var returnedObj = _mapper.Map<AccessMatrixDTO>(updatedObject);
                return new ResponseModel<AccessMatrixDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccessMatrixDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            