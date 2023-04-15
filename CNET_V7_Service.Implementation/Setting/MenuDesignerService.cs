
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
    public class MenuDesignerService : IMenuDesignerService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MenuDesignerService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<MenuDesignerDTO>> Create(MenuDesignerDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<MenuDesigner>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.MenuDesigner.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<MenuDesignerDTO>(createdObj);
                
                //return response object

                return new ResponseModel<MenuDesignerDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MenuDesignerDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MenuDesignerDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.MenuDesigner.Delete(id);
                var returnedObj = _mapper.Map<MenuDesignerDTO>(res);
                return new ResponseModel<MenuDesignerDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MenuDesignerDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<MenuDesignerDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.MenuDesigner.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<MenuDesignerDTO>>(result);
                return new ResponseModel<IEnumerable<MenuDesignerDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<MenuDesignerDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MenuDesignerDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.MenuDesigner.FindById(id);
                var returnedObj = _mapper.Map<MenuDesignerDTO>(result);
                return new ResponseModel<MenuDesignerDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MenuDesignerDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<MenuDesignerDTO>> Update(MenuDesignerDTO entity)
        {
            try
            {
                var account = _mapper.Map<MenuDesigner>(entity);
                var updatedObject = await _repository.MenuDesigner.Update(account);
                var returnedObj = _mapper.Map<MenuDesignerDTO>(updatedObject);
                return new ResponseModel<MenuDesignerDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<MenuDesignerDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            