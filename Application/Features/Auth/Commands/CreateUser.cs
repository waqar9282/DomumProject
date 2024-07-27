using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Features.Auth.Commands
{
    public  class CreateUser: IRequest<int>

    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserLevel { get; set; }
    }

    internal class CreateUserHandler : IRequestHandler<CreateUser, int>
    {
        public Task<int> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }   
}
