
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
    public class HolidayService : IHolidayService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public HolidayService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<HolidayDTO>> Create(HolidayDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Holiday>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Holiday.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<HolidayDTO>(createdObj);
                
                //return response object

                return new ResponseModel<HolidayDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<HolidayDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<HolidayDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Holiday.Delete(id);
                var returnedObj = _mapper.Map<HolidayDTO>(res);
                return new ResponseModel<HolidayDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<HolidayDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<HolidayDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Holiday.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<HolidayDTO>>(result);
                return new ResponseModel<IEnumerable<HolidayDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<HolidayDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<HolidayDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Holiday.FindById(id);
                var returnedObj = _mapper.Map<HolidayDTO>(result);
                return new ResponseModel<HolidayDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<HolidayDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<HolidayDTO>> Update(HolidayDTO entity)
        {
            try
            {
                var account = _mapper.Map<Holiday>(entity);
                var updatedObject = await _repository.Holiday.Update(account);
                var returnedObj = _mapper.Map<HolidayDTO>(updatedObject);
                return new ResponseModel<HolidayDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<HolidayDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            