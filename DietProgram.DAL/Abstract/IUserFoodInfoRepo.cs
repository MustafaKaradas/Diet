using DietProgram.Core.IBaseRepositories;
using DietProgram.DAL.Concrete.Repositories;
using DietProgram.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.DAL.Abstract
{
    public interface IUserFoodInfoRepo : IBaseRepository<UserFoodInfo>
    {

    }
}
