
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
    public class MovieScheduleService : IMovieScheduleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MovieScheduleService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<MovieScheduleDTO>> Create(MovieScheduleDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<MovieSchedule>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.MovieSchedule.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<MovieScheduleDTO>(createdObj);
                
                //return response object

                return new ResponseModel<MovieScheduleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MovieScheduleDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MovieScheduleDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.MovieSchedule.Delete(id);
                var returnedObj = _mapper.Map<MovieScheduleDTO>(res);
                return new ResponseModel<MovieScheduleDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MovieScheduleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<MovieScheduleDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.MovieSchedule.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<MovieScheduleDTO>>(result);
                return new ResponseModel<IEnumerable<MovieScheduleDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<MovieScheduleDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MovieScheduleDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.MovieSchedule.FindById(id);
                var returnedObj = _mapper.Map<MovieScheduleDTO>(result);
                return new ResponseModel<MovieScheduleDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MovieScheduleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MovieScheduleDTO>> Update(MovieScheduleDTO entity)
        {
            try
            {
                var account = _mapper.Map<MovieSchedule>(entity);
                var updatedObject = await _repository.MovieSchedule.Update(account);
                var returnedObj = _mapper.Map<MovieScheduleDTO>(updatedObject);
                return new ResponseModel<MovieScheduleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MovieScheduleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            