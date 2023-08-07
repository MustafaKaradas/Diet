using AutoMapper;
using DietProgram.BLL.Abstract.IServices;
using DietProgram.Core.Enums;
using DietProgram.DAL.Abstract;
using DietProgram.Models;
using DietProgram.Models.VMs.CategoryVM;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Concrete.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepo categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }


        public ResultService<List<CategoryDetailVM>> GetAll()
        {
            ResultService<List<CategoryDetailVM>> result = new ResultService<List<CategoryDetailVM>>();

            var categories = _categoryRepo.GetFilteredList(select: x => new CategoryDetailVM
            {
                CategoryName = x.CategoryName
            }, where: x => x.State != State.Deleted, inculudes: x => x.Foods);

            if(categories!= null)
            {
                result.Data = categories.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;

        }
    }
}
