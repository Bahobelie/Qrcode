
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
    public class SeatArrangementService : ISeatArrangementService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SeatArrangementService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SeatArrangementDTO>> Create(SeatArrangementDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<SeatArrangement>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.SeatArrangement.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<SeatArrangementDTO>(createdObj);
                
                //return response object

                return new ResponseModel<SeatArrangementDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SeatArrangementDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SeatArrangementDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.SeatArrangement.Delete(id);
                var returnedObj = _mapper.Map<SeatArrangementDTO>(res);
                return new ResponseModel<SeatArrangementDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SeatArrangementDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<SeatArrangementDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.SeatArrangement.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<SeatArrangementDTO>>(result);
                return new ResponseModel<IEnumerable<SeatArrangementDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<SeatArrangementDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SeatArrangementDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.SeatArrangement.FindById(id);
                var returnedObj = _mapper.Map<SeatArrangementDTO>(result);
                return new ResponseModel<SeatArrangementDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SeatArrangementDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SeatArrangementDTO>> Update(SeatArrangementDTO entity)
        {
            try
            {
                var account = _mapper.Map<SeatArrangement>(entity);
                var updatedObject = await _repository.SeatArrangement.Update(account);
                var returnedObj = _mapper.Map<SeatArrangementDTO>(updatedObject);
                return new ResponseModel<SeatArrangementDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SeatArrangementDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            