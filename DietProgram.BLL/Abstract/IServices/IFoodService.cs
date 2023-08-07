using DietProgram.Models.DTOs.FoodDTO;
using DietProgram.Models.VMs.FoodVM;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Abstract.IServices
{
    public interface IFoodService
    {
        ResultService<FoodCreateDTO> Create(FoodCreateVM createVM);
        bool Delete(int id);
        ResultService<FoodUpdateDTO> Update(FoodUpdateVM updateVM);
        ResultService<List<FoodDetailVM>> GetAll();
        ResultService<List<FoodDetailDTO>> FindFoodByName(string name);

    }
}
