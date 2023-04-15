
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
    public class VoucherAccountService : IVoucherAccountService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VoucherAccountService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<VoucherAccountDTO>> Create(VoucherAccountDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<VoucherAccount>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.VoucherAccount.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<VoucherAccountDTO>(createdObj);
                
                //return response object

                return new ResponseModel<VoucherAccountDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherAccountDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherAccountDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.VoucherAccount.Delete(id);
                var returnedObj = _mapper.Map<VoucherAccountDTO>(res);
                return new ResponseModel<VoucherAccountDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherAccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<VoucherAccountDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.VoucherAccount.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<VoucherAccountDTO>>(result);
                return new ResponseModel<IEnumerable<VoucherAccountDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<VoucherAccountDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherAccountDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.VoucherAccount.FindById(id);
                var returnedObj = _mapper.Map<VoucherAccountDTO>(result);
                return new ResponseModel<VoucherAccountDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherAccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherAccountDTO>> Update(VoucherAccountDTO entity)
        {
            try
            {
                var account = _mapper.Map<VoucherAccount>(entity);
                var updatedObject = await _repository.VoucherAccount.Update(account);
                var returnedObj = _mapper.Map<VoucherAccountDTO>(updatedObject);
                return new ResponseModel<VoucherAccountDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherAccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            