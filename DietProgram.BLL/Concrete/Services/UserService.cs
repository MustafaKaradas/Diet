using AutoMapper;
using DietProgram.BLL.Abstract.IServices;
using DietProgram.Core.Enums;
using DietProgram.DAL.Abstract;
using DietProgram.Entities;
using DietProgram.Models;
using DietProgram.Models.DTOs.UserDTO;
using DietProgram.Models.VMs.FoodVM;
using DietProgram.Models.VMs.UserVM;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Concrete.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public ResultService<UserCreateDTO> Create(UserCreateVM createVM)
        {
            ResultService<UserCreateDTO> result = new ResultService<UserCreateDTO>();

            UserCreateDTO createDTO = _mapper.Map<UserCreateDTO>(createVM);

            User newUser = _mapper.Map<User>(createDTO);
            var addedUser = _userRepo.Create(newUser);

            if(addedUser != null)
            {
                result.Data = createDTO;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Kullanıcı oluşturma işlemi başarısız");
            }
            return result;

        }

        public ResultService<List<UserDetailVM>> GetAll()
        {
           ResultService<List<UserDetailVM>> result = new ResultService<List<UserDetailVM>>();

            var users = _userRepo.GetFilteredList(
                select: x => new UserDetailVM
            {
                UserId = x.Id,
                UserName = x.UserName,
                Password = x.Password,
                SecurityCode = x.SecurityCode,
                UserInfoId=x.UserInfoId
            }, 
                where: x => x.State != State.Deleted, 
                inculudes: x => x.UserInfos );

            if(users != null)
            {
                result.Data = users.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;

        }

        public ResultService<UserLoginVM> Login(string username, string password)
        {
            ResultService<UserLoginVM> result = new ResultService<UserLoginVM>();

            var user = _userRepo.GetFirstOrDefault(filter: x => x.UserName.Equals(username) && x.Password.Equals(password));

            if(user != null)
            {
                var logged = new UserLoginVM
                {
                    Username = username,
                    Password = password,
                };
                result.Data = logged;
            }
            else
            {
                result.AddError(ErrorType.NotFound, "Kullanıcı bulunamadı.");
            }
            return result;

          
        }

        public ResultService<UserUpdateDTO> Update(UserUpdateVM updateVM)
        {
            ResultService<UserUpdateDTO> result = new ResultService<UserUpdateDTO>();

            var updateDto = _mapper.Map<UserUpdateDTO>(updateVM);
            var data = _mapper.Map<User>(updateDto);

            var updateData = _userRepo.Update(data);

            if(updateData!= null)
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
