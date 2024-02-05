using Freelance.Application.Services.Condidate.Candidat;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Condidate.Condidate.Commands.Create
{
    public class CreateCondidatHandler : IRequestHandler<CreateCondidatCommand , int>
    {
        private rea
        private readonly ICondidateService _condidateService;
        public CreateCondidatHandler(ICondidateService condidateService)
        {
            _condidateService = condidateService;
        }

        public async Task<int> Handle(CreateCondidatCommand command , CancellationToken cancellationToken)
        {
  
            var condidat = await _condidateService.CreateAsync();
            return condidat.Id;
        }

         
    }
}
