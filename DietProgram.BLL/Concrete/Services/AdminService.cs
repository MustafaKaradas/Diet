using AutoMapper;
using DietProgram.BLL.Abstract.IServices;
using DietProgram.DAL.Abstract;
using DietProgram.Models;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Concrete.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepo _adminRepo;
        private readonly IMapper _mapper;

        public AdminService(IAdminRepo adminRepo, IMapper mapper)
        {
            _adminRepo = adminRepo;
            _mapper = mapper;
        }

        public ResultService<AdminLoginVM> Login( string password)
        {
            ResultService<AdminLoginVM> result = new ResultService<AdminLoginVM>();

            var admin = _adminRepo.GetFirstOrDefault(filter: x => x.Password.Equals(password));

            if(admin != null)
            {
                var logged = new AdminLoginVM { Password = password };
                result.Data = logged;
            }
            else
            {
                result.AddError(ErrorType.NotFound, "Şifre Yanlış.");
            }
            return result;
          
        }
    }
}
