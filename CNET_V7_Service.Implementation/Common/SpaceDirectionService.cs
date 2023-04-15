
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
    public class SpaceDirectionService : ISpaceDirectionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SpaceDirectionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SpaceDirectionDTO>> Create(SpaceDirectionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<SpaceDirection>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.SpaceDirection.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<SpaceDirectionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<SpaceDirectionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpaceDirectionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpaceDirectionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.SpaceDirection.Delete(id);
                var returnedObj = _mapper.Map<SpaceDirectionDTO>(res);
                return new ResponseModel<SpaceDirectionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpaceDirectionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<SpaceDirectionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.SpaceDirection.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<SpaceDirectionDTO>>(result);
                return new ResponseModel<IEnumerable<SpaceDirectionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<SpaceDirectionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpaceDirectionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.SpaceDirection.FindById(id);
                var returnedObj = _mapper.Map<SpaceDirectionDTO>(result);
                return new ResponseModel<SpaceDirectionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpaceDirectionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpaceDirectionDTO>> Update(SpaceDirectionDTO entity)
        {
            try
            {
                var account = _mapper.Map<SpaceDirection>(entity);
                var updatedObject = await _repository.SpaceDirection.Update(account);
                var returnedObj = _mapper.Map<SpaceDirectionDTO>(updatedObject);
                return new ResponseModel<SpaceDirectionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpaceDirectionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            