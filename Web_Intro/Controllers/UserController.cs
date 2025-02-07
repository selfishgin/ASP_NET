using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Intro.DTOs;
using Web_Intro.Entities;

namespace Web_Intro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
	List<User> userList = new()
	{
		new User {Id = "fc7f2b01-2b45-45fc-9b72-46e0e0cc83f0", Name = "Iman", Surname="Eyvazov", Email="iman@gmail.com", Age=18  },
		new User {Id = "d63029e0-b142-4d9f-9be4-0e4ab0a1c997", Name = "Mirtalib", Surname="Amirli", Email="mirtalib@gmail.com", Age=48  },
		new User {Id = "da4ad557-cf24-449e-92f4-6c356bc3dc15", Name = "Taleh", Surname="Haciyev", Email="taleh@gmail.com", Age=25  }
	};


	[HttpGet]
	[Route("UserList")]
	public List<User> GetUserList()
	{
		return userList;
	}

	[HttpGet]
	[Route("GetById/{id}")]
	public User GetUserById(string id)
	{
		return userList.FirstOrDefault(u => u.Id == id);
	}


	[HttpPost]
	public List<User> Add( User user)
	{
		userList.Add(user);
		return userList;
	}

	[HttpPut("{id}")]
	public List<User> Update(string id, UpdateUserDTO model)
	{
		var currentUser = userList.FirstOrDefault(u=>u.Id==id);
		currentUser.Name=model.Name;
		currentUser.Surname=model.Surname;
		return userList;
	}


	[HttpDelete]
	public List<User> Delete(string id)
	{
		var currentUser = userList.FirstOrDefault(u=>u.Id== id);
		userList.Remove(currentUser);
		return userList;
	}



}
