using Sample.Application.Dtos;

namespace Sample.Application.Commands.SignIn
{
    public class SignInUserCommandResult
    {
        public SignInUserCommandResult()
        {
        }

        public SignInUserCommandResult(string token, UserDto user)
        {
            Token = token;
            User = user;
        }

        public string Token { get; set; }
        public UserDto User { get; set; }
    }
}