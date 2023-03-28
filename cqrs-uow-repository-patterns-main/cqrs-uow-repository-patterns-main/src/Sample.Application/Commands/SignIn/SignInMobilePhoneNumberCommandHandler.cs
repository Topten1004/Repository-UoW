using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Sample.Application.Interfaces;
using Sample.Application.Response;

namespace Sample.Application.Commands.SignIn
{
    public class SignInMobilePhoneNumberCommandHandler : IRequestHandler<SignInMobilePhoneNumberCommand, ServiceResponse<bool>>
    {
        
        private readonly IUnitOfWork _unitOfWork;

        public SignInMobilePhoneNumberCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public Task<ServiceResponse<bool>> Handle(SignInMobilePhoneNumberCommand request, CancellationToken cancellationToken)
        {
            
            throw new System.NotImplementedException();
        }
    }
}