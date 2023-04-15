
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
    public class VoucherExtensionService : IVoucherExtensionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VoucherExtensionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<VoucherExtensionDTO>> Create(VoucherExtensionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<VoucherExtension>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.VoucherExtension.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<VoucherExtensionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<VoucherExtensionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherExtensionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherExtensionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.VoucherExtension.Delete(id);
                var returnedObj = _mapper.Map<VoucherExtensionDTO>(res);
                return new ResponseModel<VoucherExtensionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherExtensionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<VoucherExtensionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.VoucherExtension.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<VoucherExtensionDTO>>(result);
                return new ResponseModel<IEnumerable<VoucherExtensionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<VoucherExtensionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherExtensionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.VoucherExtension.FindById(id);
                var returnedObj = _mapper.Map<VoucherExtensionDTO>(result);
                return new ResponseModel<VoucherExtensionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherExtensionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherExtensionDTO>> Update(VoucherExtensionDTO entity)
        {
            try
            {
                var account = _mapper.Map<VoucherExtension>(entity);
                var updatedObject = await _repository.VoucherExtension.Update(account);
                var returnedObj = _mapper.Map<VoucherExtensionDTO>(updatedObject);
                return new ResponseModel<VoucherExtensionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherExtensionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            