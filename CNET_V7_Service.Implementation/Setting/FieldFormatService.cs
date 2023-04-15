
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
    public class FieldFormatService : IFieldFormatService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FieldFormatService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<FieldFormatDTO>> Create(FieldFormatDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<FieldFormat>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.FieldFormat.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<FieldFormatDTO>(createdObj);
                
                //return response object

                return new ResponseModel<FieldFormatDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<FieldFormatDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<FieldFormatDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.FieldFormat.Delete(id);
                var returnedObj = _mapper.Map<FieldFormatDTO>(res);
                return new ResponseModel<FieldFormatDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<FieldFormatDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<FieldFormatDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.FieldFormat.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<FieldFormatDTO>>(result);
                return new ResponseModel<IEnumerable<FieldFormatDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<FieldFormatDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<FieldFormatDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.FieldFormat.FindById(id);
                var returnedObj = _mapper.Map<FieldFormatDTO>(result);
                return new ResponseModel<FieldFormatDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<FieldFormatDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<FieldFormatDTO>> Update(FieldFormatDTO entity)
        {
            try
            {
                var account = _mapper.Map<FieldFormat>(entity);
                var updatedObject = await _repository.FieldFormat.Update(account);
                var returnedObj = _mapper.Map<FieldFormatDTO>(updatedObject);
                return new ResponseModel<FieldFormatDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<FieldFormatDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            