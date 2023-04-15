
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
    public class SystemConstantService : ISystemConstantService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SystemConstantService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SystemConstantDTO>> Create(SystemConstantDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<SystemConstant>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.SystemConstant.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<SystemConstantDTO>(createdObj);
                
                //return response object

                return new ResponseModel<SystemConstantDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SystemConstantDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SystemConstantDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.SystemConstant.Delete(id);
                var returnedObj = _mapper.Map<SystemConstantDTO>(res);
                return new ResponseModel<SystemConstantDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SystemConstantDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<SystemConstantDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.SystemConstant.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<SystemConstantDTO>>(result);
                return new ResponseModel<IEnumerable<SystemConstantDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<SystemConstantDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SystemConstantDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.SystemConstant.FindById(id);
                var returnedObj = _mapper.Map<SystemConstantDTO>(result);
                return new ResponseModel<SystemConstantDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SystemConstantDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SystemConstantDTO>> Update(SystemConstantDTO entity)
        {
            try
            {
                var account = _mapper.Map<SystemConstant>(entity);
                var updatedObject = await _repository.SystemConstant.Update(account);
                var returnedObj = _mapper.Map<SystemConstantDTO>(updatedObject);
                return new ResponseModel<SystemConstantDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SystemConstantDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            