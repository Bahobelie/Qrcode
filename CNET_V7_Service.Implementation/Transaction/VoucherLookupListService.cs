
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
    public class VoucherLookupListService : IVoucherLookupListService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VoucherLookupListService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<VoucherLookupListDTO>> Create(VoucherLookupListDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<VoucherLookupList>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.VoucherLookupList.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<VoucherLookupListDTO>(createdObj);
                
                //return response object

                return new ResponseModel<VoucherLookupListDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherLookupListDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherLookupListDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.VoucherLookupList.Delete(id);
                var returnedObj = _mapper.Map<VoucherLookupListDTO>(res);
                return new ResponseModel<VoucherLookupListDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherLookupListDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<VoucherLookupListDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.VoucherLookupList.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<VoucherLookupListDTO>>(result);
                return new ResponseModel<IEnumerable<VoucherLookupListDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<VoucherLookupListDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherLookupListDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.VoucherLookupList.FindById(id);
                var returnedObj = _mapper.Map<VoucherLookupListDTO>(result);
                return new ResponseModel<VoucherLookupListDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherLookupListDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherLookupListDTO>> Update(VoucherLookupListDTO entity)
        {
            try
            {
                var account = _mapper.Map<VoucherLookupList>(entity);
                var updatedObject = await _repository.VoucherLookupList.Update(account);
                var returnedObj = _mapper.Map<VoucherLookupListDTO>(updatedObject);
                return new ResponseModel<VoucherLookupListDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherLookupListDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            