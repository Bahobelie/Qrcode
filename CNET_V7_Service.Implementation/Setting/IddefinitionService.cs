
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
    public class IddefinitionService : IIddefinitionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public IddefinitionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<IddefinitionDTO>> Create(IddefinitionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Iddefinition>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Iddefinition.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<IddefinitionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<IddefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IddefinitionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IddefinitionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Iddefinition.Delete(id);
                var returnedObj = _mapper.Map<IddefinitionDTO>(res);
                return new ResponseModel<IddefinitionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IddefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<IddefinitionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Iddefinition.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<IddefinitionDTO>>(result);
                return new ResponseModel<IEnumerable<IddefinitionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<IddefinitionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IddefinitionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Iddefinition.FindById(id);
                var returnedObj = _mapper.Map<IddefinitionDTO>(result);
                return new ResponseModel<IddefinitionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IddefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IddefinitionDTO>> Update(IddefinitionDTO entity)
        {
            try
            {
                var account = _mapper.Map<Iddefinition>(entity);
                var updatedObject = await _repository.Iddefinition.Update(account);
                var returnedObj = _mapper.Map<IddefinitionDTO>(updatedObject);
                return new ResponseModel<IddefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IddefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            