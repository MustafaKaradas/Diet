using DietProgram.DAL.Abstract;
using DietProgram.DAL.Base.EntityFramework;
using DietProgram.DAL.Concrete.Context;
using DietProgram.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.DAL.Concrete.Repositories
{
    public class UserInfoRepo : BaseRepository<UserInfo, DietProgramDbContext>, IUserInfoRepo
    {
        public UserInfoRepo(DietProgramDbContext context) : base(context)
        {
        }
    }
}
