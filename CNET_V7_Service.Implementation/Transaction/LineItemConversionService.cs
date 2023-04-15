
using AutoMapper;
using CNET_V7_Domain.DataModels.TransactionSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.TransactionSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.TransactionSchema
{
    public class LineItemConversionService : ILineItemConversionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LineItemConversionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<LineItemConversionDTO>> Create(LineItemConversionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<LineItemConversion>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.LineItemConversion.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<LineItemConversionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<LineItemConversionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LineItemConversionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LineItemConversionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.LineItemConversion.Delete(id);
                var returnedObj = _mapper.Map<LineItemConversionDTO>(res);
                return new ResponseModel<LineItemConversionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LineItemConversionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<LineItemConversionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.LineItemConversion.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<LineItemConversionDTO>>(result);
                return new ResponseModel<IEnumerable<LineItemConversionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<LineItemConversionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LineItemConversionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.LineItemConversion.FindById(id);
                var returnedObj = _mapper.Map<LineItemConversionDTO>(result);
                return new ResponseModel<LineItemConversionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LineItemConversionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LineItemConversionDTO>> Update(LineItemConversionDTO entity)
        {
            try
            {
                var account = _mapper.Map<LineItemConversion>(entity);
                var updatedObject = await _repository.LineItemConversion.Update(account);
                var returnedObj = _mapper.Map<LineItemConversionDTO>(updatedObject);
                return new ResponseModel<LineItemConversionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LineItemConversionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            