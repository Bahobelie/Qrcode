
using AutoMapper;
using CNET_V7_Domain.DataModels.ArticleSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.ArticleSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.ArticleSchema
{
    public class ConversionDefinitionService : IConversionDefinitionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ConversionDefinitionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ConversionDefinitionDTO>> Create(ConversionDefinitionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ConversionDefinition>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ConversionDefinition.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ConversionDefinitionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ConversionDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConversionDefinitionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConversionDefinitionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ConversionDefinition.Delete(id);
                var returnedObj = _mapper.Map<ConversionDefinitionDTO>(res);
                return new ResponseModel<ConversionDefinitionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConversionDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ConversionDefinitionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ConversionDefinition.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ConversionDefinitionDTO>>(result);
                return new ResponseModel<IEnumerable<ConversionDefinitionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ConversionDefinitionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConversionDefinitionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ConversionDefinition.FindById(id);
                var returnedObj = _mapper.Map<ConversionDefinitionDTO>(result);
                return new ResponseModel<ConversionDefinitionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConversionDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConversionDefinitionDTO>> Update(ConversionDefinitionDTO entity)
        {
            try
            {
                var account = _mapper.Map<ConversionDefinition>(entity);
                var updatedObject = await _repository.ConversionDefinition.Update(account);
                var returnedObj = _mapper.Map<ConversionDefinitionDTO>(updatedObject);
                return new ResponseModel<ConversionDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConversionDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            