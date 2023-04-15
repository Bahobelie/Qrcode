
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
    public class DenominationService : IDenominationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DenominationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<DenominationDTO>> Create(DenominationDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Denomination>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Denomination.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<DenominationDTO>(createdObj);
                
                //return response object

                return new ResponseModel<DenominationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DenominationDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DenominationDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Denomination.Delete(id);
                var returnedObj = _mapper.Map<DenominationDTO>(res);
                return new ResponseModel<DenominationDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DenominationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<DenominationDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Denomination.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<DenominationDTO>>(result);
                return new ResponseModel<IEnumerable<DenominationDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<DenominationDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DenominationDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Denomination.FindById(id);
                var returnedObj = _mapper.Map<DenominationDTO>(result);
                return new ResponseModel<DenominationDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DenominationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DenominationDTO>> Update(DenominationDTO entity)
        {
            try
            {
                var account = _mapper.Map<Denomination>(entity);
                var updatedObject = await _repository.Denomination.Update(account);
                var returnedObj = _mapper.Map<DenominationDTO>(updatedObject);
                return new ResponseModel<DenominationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DenominationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            