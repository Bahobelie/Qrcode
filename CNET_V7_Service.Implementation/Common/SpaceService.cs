
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
    public class SpaceService : ISpaceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SpaceService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SpaceDTO>> Create(SpaceDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Space>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Space.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<SpaceDTO>(createdObj);
                
                //return response object

                return new ResponseModel<SpaceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpaceDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpaceDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Space.Delete(id);
                var returnedObj = _mapper.Map<SpaceDTO>(res);
                return new ResponseModel<SpaceDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpaceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<SpaceDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Space.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<SpaceDTO>>(result);
                return new ResponseModel<IEnumerable<SpaceDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<SpaceDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpaceDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Space.FindById(id);
                var returnedObj = _mapper.Map<SpaceDTO>(result);
                return new ResponseModel<SpaceDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpaceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpaceDTO>> Update(SpaceDTO entity)
        {
            try
            {
                var account = _mapper.Map<Space>(entity);
                var updatedObject = await _repository.Space.Update(account);
                var returnedObj = _mapper.Map<SpaceDTO>(updatedObject);
                return new ResponseModel<SpaceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpaceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            