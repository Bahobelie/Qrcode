
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
    public class VoucherStoreMappingService : IVoucherStoreMappingService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VoucherStoreMappingService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<VoucherStoreMappingDTO>> Create(VoucherStoreMappingDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<VoucherStoreMapping>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.VoucherStoreMapping.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<VoucherStoreMappingDTO>(createdObj);
                
                //return response object

                return new ResponseModel<VoucherStoreMappingDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherStoreMappingDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherStoreMappingDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.VoucherStoreMapping.Delete(id);
                var returnedObj = _mapper.Map<VoucherStoreMappingDTO>(res);
                return new ResponseModel<VoucherStoreMappingDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherStoreMappingDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<VoucherStoreMappingDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.VoucherStoreMapping.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<VoucherStoreMappingDTO>>(result);
                return new ResponseModel<IEnumerable<VoucherStoreMappingDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<VoucherStoreMappingDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherStoreMappingDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.VoucherStoreMapping.FindById(id);
                var returnedObj = _mapper.Map<VoucherStoreMappingDTO>(result);
                return new ResponseModel<VoucherStoreMappingDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherStoreMappingDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherStoreMappingDTO>> Update(VoucherStoreMappingDTO entity)
        {
            try
            {
                var account = _mapper.Map<VoucherStoreMapping>(entity);
                var updatedObject = await _repository.VoucherStoreMapping.Update(account);
                var returnedObj = _mapper.Map<VoucherStoreMappingDTO>(updatedObject);
                return new ResponseModel<VoucherStoreMappingDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherStoreMappingDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            