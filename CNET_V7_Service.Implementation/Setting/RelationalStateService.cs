
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
    public class RelationalStateService : IRelationalStateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RelationalStateService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<RelationalStateDTO>> Create(RelationalStateDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<RelationalState>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.RelationalState.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<RelationalStateDTO>(createdObj);
                
                //return response object

                return new ResponseModel<RelationalStateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RelationalStateDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RelationalStateDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.RelationalState.Delete(id);
                var returnedObj = _mapper.Map<RelationalStateDTO>(res);
                return new ResponseModel<RelationalStateDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RelationalStateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<RelationalStateDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.RelationalState.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<RelationalStateDTO>>(result);
                return new ResponseModel<IEnumerable<RelationalStateDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<RelationalStateDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RelationalStateDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.RelationalState.FindById(id);
                var returnedObj = _mapper.Map<RelationalStateDTO>(result);
                return new ResponseModel<RelationalStateDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RelationalStateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RelationalStateDTO>> Update(RelationalStateDTO entity)
        {
            try
            {
                var account = _mapper.Map<RelationalState>(entity);
                var updatedObject = await _repository.RelationalState.Update(account);
                var returnedObj = _mapper.Map<RelationalStateDTO>(updatedObject);
                return new ResponseModel<RelationalStateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RelationalStateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            