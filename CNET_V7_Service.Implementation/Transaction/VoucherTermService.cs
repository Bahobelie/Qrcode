
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
    public class VoucherTermService : IVoucherTermService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VoucherTermService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<VoucherTermDTO>> Create(VoucherTermDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<VoucherTerm>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.VoucherTerm.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<VoucherTermDTO>(createdObj);
                
                //return response object

                return new ResponseModel<VoucherTermDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherTermDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherTermDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.VoucherTerm.Delete(id);
                var returnedObj = _mapper.Map<VoucherTermDTO>(res);
                return new ResponseModel<VoucherTermDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherTermDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<VoucherTermDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.VoucherTerm.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<VoucherTermDTO>>(result);
                return new ResponseModel<IEnumerable<VoucherTermDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<VoucherTermDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherTermDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.VoucherTerm.FindById(id);
                var returnedObj = _mapper.Map<VoucherTermDTO>(result);
                return new ResponseModel<VoucherTermDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherTermDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherTermDTO>> Update(VoucherTermDTO entity)
        {
            try
            {
                var account = _mapper.Map<VoucherTerm>(entity);
                var updatedObject = await _repository.VoucherTerm.Update(account);
                var returnedObj = _mapper.Map<VoucherTermDTO>(updatedObject);
                return new ResponseModel<VoucherTermDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherTermDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            