using Do_An_Tot_Nghiep.Dto.Auth;

namespace Do_An_Tot_Nghiep.Services.Auth;

public interface IAuthService
{
    Task<Models.User> Login(UserLoginDto userLogin);
    Task<Models.User> Register(UserRegisterDto userRegister);
    Task<Object> GetUserInfo();
    Task<string> HashPassword(string password);
    Task<bool> VerifyPassword(string password, string storedPasswordHash);

}