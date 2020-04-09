using KosykFinalApp.Database.Models;

namespace KosykFinalApp.Managers.DB
{
    public class LoginResult
    {
        public bool Result { get; }
        public IAutorizedUser AutorizedUser { get; }

        public LoginResult(bool result, IAutorizedUser autorizedUser)
        {
            Result = result;
            AutorizedUser = autorizedUser;
        }

        public static implicit operator bool(LoginResult loginResult)
        {
            return loginResult.Result;
        }
    }
}
