
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
    public class DistributionService : IDistributionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DistributionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<DistributionDTO>> Create(DistributionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Distribution>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Distribution.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<DistributionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<DistributionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DistributionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DistributionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Distribution.Delete(id);
                var returnedObj = _mapper.Map<DistributionDTO>(res);
                return new ResponseModel<DistributionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DistributionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<DistributionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Distribution.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<DistributionDTO>>(result);
                return new ResponseModel<IEnumerable<DistributionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<DistributionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DistributionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Distribution.FindById(id);
                var returnedObj = _mapper.Map<DistributionDTO>(result);
                return new ResponseModel<DistributionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DistributionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DistributionDTO>> Update(DistributionDTO entity)
        {
            try
            {
                var account = _mapper.Map<Distribution>(entity);
                var updatedObject = await _repository.Distribution.Update(account);
                var returnedObj = _mapper.Map<DistributionDTO>(updatedObject);
                return new ResponseModel<DistributionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DistributionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            