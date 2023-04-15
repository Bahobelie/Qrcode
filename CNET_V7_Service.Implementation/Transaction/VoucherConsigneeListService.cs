
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
    public class VoucherConsigneeListService : IVoucherConsigneeListService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VoucherConsigneeListService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<VoucherConsigneeListDTO>> Create(VoucherConsigneeListDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<VoucherConsigneeList>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.VoucherConsigneeList.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<VoucherConsigneeListDTO>(createdObj);
                
                //return response object

                return new ResponseModel<VoucherConsigneeListDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherConsigneeListDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherConsigneeListDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.VoucherConsigneeList.Delete(id);
                var returnedObj = _mapper.Map<VoucherConsigneeListDTO>(res);
                return new ResponseModel<VoucherConsigneeListDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherConsigneeListDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<VoucherConsigneeListDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.VoucherConsigneeList.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<VoucherConsigneeListDTO>>(result);
                return new ResponseModel<IEnumerable<VoucherConsigneeListDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<VoucherConsigneeListDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherConsigneeListDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.VoucherConsigneeList.FindById(id);
                var returnedObj = _mapper.Map<VoucherConsigneeListDTO>(result);
                return new ResponseModel<VoucherConsigneeListDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherConsigneeListDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<VoucherConsigneeListDTO>> Update(VoucherConsigneeListDTO entity)
        {
            try
            {
                var account = _mapper.Map<VoucherConsigneeList>(entity);
                var updatedObject = await _repository.VoucherConsigneeList.Update(account);
                var returnedObj = _mapper.Map<VoucherConsigneeListDTO>(updatedObject);
                return new ResponseModel<VoucherConsigneeListDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<VoucherConsigneeListDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            