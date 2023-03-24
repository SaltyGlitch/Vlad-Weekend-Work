using FinalProject.Services.Interfaces;

namespace FinalProject.Services;

public class UserService : IUserService
{
    private Context _context { get; set; }

    public UserService(Context context)
    {
        _context = context;
    }
    
    
}