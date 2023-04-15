
using AutoMapper;
using CNET_V7_Domain.DataModels.TransactionSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.TransactionSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.TransactionSchema
{
    public class PreferentialValueFactorService : IPreferentialValueFactorService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PreferentialValueFactorService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PreferentialValueFactorDTO>> Create(PreferentialValueFactorDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<PreferentialValueFactor>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.PreferentialValueFactor.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<PreferentialValueFactorDTO>(createdObj);
                
                //return response object

                return new ResponseModel<PreferentialValueFactorDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferentialValueFactorDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferentialValueFactorDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.PreferentialValueFactor.Delete(id);
                var returnedObj = _mapper.Map<PreferentialValueFactorDTO>(res);
                return new ResponseModel<PreferentialValueFactorDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferentialValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<PreferentialValueFactorDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.PreferentialValueFactor.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<PreferentialValueFactorDTO>>(result);
                return new ResponseModel<IEnumerable<PreferentialValueFactorDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<PreferentialValueFactorDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferentialValueFactorDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.PreferentialValueFactor.FindById(id);
                var returnedObj = _mapper.Map<PreferentialValueFactorDTO>(result);
                return new ResponseModel<PreferentialValueFactorDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferentialValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferentialValueFactorDTO>> Update(PreferentialValueFactorDTO entity)
        {
            try
            {
                var account = _mapper.Map<PreferentialValueFactor>(entity);
                var updatedObject = await _repository.PreferentialValueFactor.Update(account);
                var returnedObj = _mapper.Map<PreferentialValueFactorDTO>(updatedObject);
                return new ResponseModel<PreferentialValueFactorDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferentialValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            