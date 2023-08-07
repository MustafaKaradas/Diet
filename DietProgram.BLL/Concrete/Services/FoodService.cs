using AutoMapper;
using DietProgram.BLL.Abstract.IServices;
using DietProgram.Core.Enums;
using DietProgram.DAL.Abstract;
using DietProgram.Entities;
using DietProgram.Models.DTOs.FoodDTO;
using DietProgram.Models.VMs.FoodVM;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Concrete.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepo _foodRepo;
        private readonly IMapper _mapper;

        public FoodService(IMapper mapper, IFoodRepo foodRepo)
        {
            _foodRepo = foodRepo;
            _mapper = mapper;
           
        }

        public ResultService<FoodCreateDTO> Create(FoodCreateVM createVM)
        {
            ResultService<FoodCreateDTO> result = new ResultService<FoodCreateDTO>();   

            FoodCreateDTO createDto = _mapper.Map<FoodCreateDTO>(createVM);
            Food newFood = _mapper.Map<Food>(createDto);
            var addedFood= _foodRepo.Create(newFood);

            if(addedFood != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
           

        }

        public bool Delete(int id)
        {
            Food food = _foodRepo.GetFirstOrDefault(filter: x => x.Id == id);

            if (food != null)
            {

                return _foodRepo.Delete(food);

                

            }
            return false;
            

        }

        public ResultService<List<FoodDetailDTO>> FindFoodByName(string name)
        {
            ResultService<List<FoodDetailDTO>> result = new ResultService<List<FoodDetailDTO>>();

            var foods = _foodRepo.GetFilteredList(select: x => new FoodDetailDTO
            {

                FoodName = x.FoodName,
                Kcal = x.Kcal,
                Protein = x.Protein,
                Carbonhydrate = x.Carbonhydrate,
                Fat = x.Fat,
                Picture = x.Picture,

            }, where: x => x.FoodName== name, inculudes: x => x.Category);

            if (foods != null)
            {
                result.Data = foods.ToList();
            }
            else
            {
                result.AddError(ErrorType.NotFound, "Aradığınız isimde bir besin yoktur.");
            }
            return result;

        }

        public ResultService<List<FoodDetailVM>> GetAll()
        {
            ResultService<List<FoodDetailVM>> result = new ResultService<List<FoodDetailVM>>();

            var foods = _foodRepo.GetFilteredList(select: x => new FoodDetailVM
            {
                CategoryId=x.CategoryId??0,
                FoodName = x.FoodName,
                Kcal = x.Kcal,
                Protein = x.Protein,
                Carbonhydrate = x.Carbonhydrate,
                Fat = x.Fat,
                Picture = x.Picture,
                
            },where: x=> x.State!= State.Deleted, inculudes: x=> x.Category);

            if(foods != null)
            {
                result.Data= foods.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;
        }

        public ResultService<FoodUpdateDTO> Update(FoodUpdateVM updateVM)
        {
            ResultService<FoodUpdateDTO> result = new ResultService<FoodUpdateDTO>();

            var updateDto = _mapper.Map<FoodUpdateDTO>(updateVM);
            var data = _mapper.Map<Food>(updateDto);

            var updateData= _foodRepo.Update(data);

            if(updateData != null)
            {
                result.Data = updateDto;
            }
            else
            {
                result.AddError(ErrorType.ServerError, "Güncelleme işlemi başarısız");
            }
            return result;

        }
    }
}
