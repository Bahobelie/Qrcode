
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
    public class TermDefinitionService : ITermDefinitionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TermDefinitionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TermDefinitionDTO>> Create(TermDefinitionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<TermDefinition>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.TermDefinition.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<TermDefinitionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<TermDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TermDefinitionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TermDefinitionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.TermDefinition.Delete(id);
                var returnedObj = _mapper.Map<TermDefinitionDTO>(res);
                return new ResponseModel<TermDefinitionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TermDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<TermDefinitionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.TermDefinition.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<TermDefinitionDTO>>(result);
                return new ResponseModel<IEnumerable<TermDefinitionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<TermDefinitionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TermDefinitionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.TermDefinition.FindById(id);
                var returnedObj = _mapper.Map<TermDefinitionDTO>(result);
                return new ResponseModel<TermDefinitionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TermDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TermDefinitionDTO>> Update(TermDefinitionDTO entity)
        {
            try
            {
                var account = _mapper.Map<TermDefinition>(entity);
                var updatedObject = await _repository.TermDefinition.Update(account);
                var returnedObj = _mapper.Map<TermDefinitionDTO>(updatedObject);
                return new ResponseModel<TermDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TermDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            