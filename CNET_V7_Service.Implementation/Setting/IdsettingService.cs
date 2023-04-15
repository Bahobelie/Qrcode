
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
    public class IdsettingService : IIdsettingService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public IdsettingService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<IdsettingDTO>> Create(IdsettingDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Idsetting>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Idsetting.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<IdsettingDTO>(createdObj);
                
                //return response object

                return new ResponseModel<IdsettingDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IdsettingDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IdsettingDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Idsetting.Delete(id);
                var returnedObj = _mapper.Map<IdsettingDTO>(res);
                return new ResponseModel<IdsettingDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IdsettingDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<IdsettingDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Idsetting.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<IdsettingDTO>>(result);
                return new ResponseModel<IEnumerable<IdsettingDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<IdsettingDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IdsettingDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Idsetting.FindById(id);
                var returnedObj = _mapper.Map<IdsettingDTO>(result);
                return new ResponseModel<IdsettingDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IdsettingDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IdsettingDTO>> Update(IdsettingDTO entity)
        {
            try
            {
                var account = _mapper.Map<Idsetting>(entity);
                var updatedObject = await _repository.Idsetting.Update(account);
                var returnedObj = _mapper.Map<IdsettingDTO>(updatedObject);
                return new ResponseModel<IdsettingDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IdsettingDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            