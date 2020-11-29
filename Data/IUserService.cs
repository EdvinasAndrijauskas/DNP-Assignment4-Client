using System.Threading.Tasks;
using Managing_Adults.Models;

namespace Managing_Adults.Data {
public interface IUserService {
    Task<User> ValidateUser(string userName, string password);
}
}