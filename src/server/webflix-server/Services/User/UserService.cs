using Microsoft.EntityFrameworkCore;
using webflix_server.Data;
using webflix_server.Data.Models;

namespace webflix_server.Services;

public class UserService : IUserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task RegisterUser(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User> FindOne(object value)
    {
        var result = await _context.Users.FirstOrDefaultAsync(u => u.Email == value.ToString());
        
        return result;
    }
}