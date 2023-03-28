using System.ComponentModel.DataAnnotations;
using MediatR;
using Sample.Application.Response;

namespace Sample.Application.Commands.SignIn
{
    public class SignInMobilePhoneNumberCommand : IRequest<ServiceResponse<bool>>
    {
        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz")]
        public string MobilePhoneNumber { get; set; } = "05446963445";
    }
}