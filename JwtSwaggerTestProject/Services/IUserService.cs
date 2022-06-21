using JwtSwaggerTestProject.Models;

namespace JwtSwaggerTestProject.Services
{
	public interface IUserService
	{
		public User Get(UserLogin userLogin);
	}
}
