
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
    public class CnetlicenseService : ICnetlicenseService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CnetlicenseService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CnetlicenseDTO>> Create(CnetlicenseDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Cnetlicense>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Cnetlicense.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<CnetlicenseDTO>(createdObj);
                
                //return response object

                return new ResponseModel<CnetlicenseDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CnetlicenseDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CnetlicenseDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Cnetlicense.Delete(id);
                var returnedObj = _mapper.Map<CnetlicenseDTO>(res);
                return new ResponseModel<CnetlicenseDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CnetlicenseDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<CnetlicenseDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Cnetlicense.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<CnetlicenseDTO>>(result);
                return new ResponseModel<IEnumerable<CnetlicenseDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<CnetlicenseDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CnetlicenseDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Cnetlicense.FindById(id);
                var returnedObj = _mapper.Map<CnetlicenseDTO>(result);
                return new ResponseModel<CnetlicenseDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CnetlicenseDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CnetlicenseDTO>> Update(CnetlicenseDTO entity)
        {
            try
            {
                var account = _mapper.Map<Cnetlicense>(entity);
                var updatedObject = await _repository.Cnetlicense.Update(account);
                var returnedObj = _mapper.Map<CnetlicenseDTO>(updatedObject);
                return new ResponseModel<CnetlicenseDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CnetlicenseDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            