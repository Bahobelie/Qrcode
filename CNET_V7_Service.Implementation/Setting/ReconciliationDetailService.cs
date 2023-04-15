
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
    public class ReconciliationDetailService : IReconciliationDetailService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReconciliationDetailService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ReconciliationDetailDTO>> Create(ReconciliationDetailDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ReconciliationDetail>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ReconciliationDetail.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ReconciliationDetailDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ReconciliationDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReconciliationDetailDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReconciliationDetailDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ReconciliationDetail.Delete(id);
                var returnedObj = _mapper.Map<ReconciliationDetailDTO>(res);
                return new ResponseModel<ReconciliationDetailDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReconciliationDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ReconciliationDetailDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ReconciliationDetail.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ReconciliationDetailDTO>>(result);
                return new ResponseModel<IEnumerable<ReconciliationDetailDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ReconciliationDetailDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReconciliationDetailDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ReconciliationDetail.FindById(id);
                var returnedObj = _mapper.Map<ReconciliationDetailDTO>(result);
                return new ResponseModel<ReconciliationDetailDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReconciliationDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ReconciliationDetailDTO>> Update(ReconciliationDetailDTO entity)
        {
            try
            {
                var account = _mapper.Map<ReconciliationDetail>(entity);
                var updatedObject = await _repository.ReconciliationDetail.Update(account);
                var returnedObj = _mapper.Map<ReconciliationDetailDTO>(updatedObject);
                return new ResponseModel<ReconciliationDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ReconciliationDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            