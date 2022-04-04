using webflix_server.Data.Models;

namespace webflix_server.Services;

public interface IUserService
{
    public Task RegisterUser(User user);
    
    // utils
    public Task<User> FindOne(object value);
}