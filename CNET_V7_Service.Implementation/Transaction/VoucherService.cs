
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
    public class VoucherService : IVoucherService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VoucherService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<VoucherDTO>> Create(VoucherDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Voucher>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Voucher.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<VoucherDTO>(createdObj);
                
                //return response object

                return new ResponseModel<VoucherDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Voucher.Delete(id);
                var returnedObj = _mapper.Map<VoucherDTO>(res);
                return new ResponseModel<VoucherDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<VoucherDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Voucher.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<VoucherDTO>>(result);
                return new ResponseModel<IEnumerable<VoucherDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<VoucherDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Voucher.FindById(id);
                var returnedObj = _mapper.Map<VoucherDTO>(result);
                return new ResponseModel<VoucherDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherDTO>> Update(VoucherDTO entity)
        {
            try
            {
                var account = _mapper.Map<Voucher>(entity);
                var updatedObject = await _repository.Voucher.Update(account);
                var returnedObj = _mapper.Map<VoucherDTO>(updatedObject);
                return new ResponseModel<VoucherDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            