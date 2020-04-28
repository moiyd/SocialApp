using System.Threading.Tasks;
using SocialApp.API.Models;

namespace SocialApp.API.Data
{
    public interface IAuthRepository
    {
         //Register the User. [User] is defind in Models 
        Task<User> Register(User user, string password);
                       
        //Login the User
        Task<User> Login(string username, string password);
        
        //Check User Existance
        Task<bool> UserExists(string username);
    }
}