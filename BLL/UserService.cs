using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;
using Models.Dto;

namespace BLL
{
	public interface IUserService
	{
		Task<int> AddUser(UserDto user);

		Task<List<UserDto>> GetAllUsers();
	}
	
	public class UserService: IUserService
	{
		private readonly IUserRepository _userRepository;
		
		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		
		public async Task<int> AddUser(UserDto user)
		{
			return await _userRepository.AddUserAsync(new User
			{
				Name = user.Name,
				DOB = user.DOB,
				Complaints = user.Complaints,
				Sex = user.Sex == "male",
				Id = Guid.NewGuid()
			});
		}

		public async Task<List<UserDto>> GetAllUsers()
		{
			var usersList = new List<UserDto>();

			var users = await _userRepository.GetAllUsersUser();

			foreach (var user in users)
			{
				usersList.Add(new UserDto{
					Id = user.Id.ToString(),
					Name = user.Name,
					DOB = user.DOB,
					Complaints = user.Complaints,
					Sex = user.Sex ? "male": "female"
				});
			}

			return usersList;
		}
	}
}