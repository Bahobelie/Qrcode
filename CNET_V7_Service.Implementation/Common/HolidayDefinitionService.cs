
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
    public class HolidayDefinitionService : IHolidayDefinitionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public HolidayDefinitionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<HolidayDefinitionDTO>> Create(HolidayDefinitionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<HolidayDefinition>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.HolidayDefinition.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<HolidayDefinitionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<HolidayDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<HolidayDefinitionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<HolidayDefinitionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.HolidayDefinition.Delete(id);
                var returnedObj = _mapper.Map<HolidayDefinitionDTO>(res);
                return new ResponseModel<HolidayDefinitionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<HolidayDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<HolidayDefinitionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.HolidayDefinition.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<HolidayDefinitionDTO>>(result);
                return new ResponseModel<IEnumerable<HolidayDefinitionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<HolidayDefinitionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<HolidayDefinitionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.HolidayDefinition.FindById(id);
                var returnedObj = _mapper.Map<HolidayDefinitionDTO>(result);
                return new ResponseModel<HolidayDefinitionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<HolidayDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<HolidayDefinitionDTO>> Update(HolidayDefinitionDTO entity)
        {
            try
            {
                var account = _mapper.Map<HolidayDefinition>(entity);
                var updatedObject = await _repository.HolidayDefinition.Update(account);
                var returnedObj = _mapper.Map<HolidayDefinitionDTO>(updatedObject);
                return new ResponseModel<HolidayDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<HolidayDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            