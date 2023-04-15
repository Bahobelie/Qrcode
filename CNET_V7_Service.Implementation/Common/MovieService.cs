
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
    public class MovieService : IMovieService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MovieService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<MovieDTO>> Create(MovieDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Movie>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Movie.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<MovieDTO>(createdObj);
                
                //return response object

                return new ResponseModel<MovieDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MovieDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MovieDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Movie.Delete(id);
                var returnedObj = _mapper.Map<MovieDTO>(res);
                return new ResponseModel<MovieDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MovieDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<MovieDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Movie.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<MovieDTO>>(result);
                return new ResponseModel<IEnumerable<MovieDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<MovieDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MovieDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Movie.FindById(id);
                var returnedObj = _mapper.Map<MovieDTO>(result);
                return new ResponseModel<MovieDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MovieDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MovieDTO>> Update(MovieDTO entity)
        {
            try
            {
                var account = _mapper.Map<Movie>(entity);
                var updatedObject = await _repository.Movie.Update(account);
                var returnedObj = _mapper.Map<MovieDTO>(updatedObject);
                return new ResponseModel<MovieDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MovieDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            