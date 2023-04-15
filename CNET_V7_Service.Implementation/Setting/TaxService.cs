
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
    public class TaxService : ITaxService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TaxService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<TaxDTO>> Create(TaxDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Tax>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Tax.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<TaxDTO>(createdObj);
                
                //return response object

                return new ResponseModel<TaxDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TaxDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TaxDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Tax.Delete(id);
                var returnedObj = _mapper.Map<TaxDTO>(res);
                return new ResponseModel<TaxDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TaxDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<TaxDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Tax.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<TaxDTO>>(result);
                return new ResponseModel<IEnumerable<TaxDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<TaxDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TaxDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Tax.FindById(id);
                var returnedObj = _mapper.Map<TaxDTO>(result);
                return new ResponseModel<TaxDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TaxDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<TaxDTO>> Update(TaxDTO entity)
        {
            try
            {
                var account = _mapper.Map<Tax>(entity);
                var updatedObject = await _repository.Tax.Update(account);
                var returnedObj = _mapper.Map<TaxDTO>(updatedObject);
                return new ResponseModel<TaxDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<TaxDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            