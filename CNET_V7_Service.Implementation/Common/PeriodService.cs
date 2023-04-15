
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
    public class PeriodService : IPeriodService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PeriodService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PeriodDTO>> Create(PeriodDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Period>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Period.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<PeriodDTO>(createdObj);
                
                //return response object

                return new ResponseModel<PeriodDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PeriodDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PeriodDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Period.Delete(id);
                var returnedObj = _mapper.Map<PeriodDTO>(res);
                return new ResponseModel<PeriodDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PeriodDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<PeriodDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Period.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<PeriodDTO>>(result);
                return new ResponseModel<IEnumerable<PeriodDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<PeriodDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PeriodDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Period.FindById(id);
                var returnedObj = _mapper.Map<PeriodDTO>(result);
                return new ResponseModel<PeriodDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PeriodDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PeriodDTO>> Update(PeriodDTO entity)
        {
            try
            {
                var account = _mapper.Map<Period>(entity);
                var updatedObject = await _repository.Period.Update(account);
                var returnedObj = _mapper.Map<PeriodDTO>(updatedObject);
                return new ResponseModel<PeriodDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PeriodDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            