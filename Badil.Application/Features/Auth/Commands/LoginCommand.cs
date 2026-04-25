using AutoMapper;
using Badil.Application.Common.Interfaces;
using Badil.Application.Features.Auth.DTOs;
using Badil.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Badil.Application.Features.Auth.Commands
{
    public class LoginCommand : LoginRequest, IRequest<LoginResponse>
    {
    }

    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public LoginCommandHandler(UserManager<AppUser> userManager, ITokenService tokenService, IMapper mapper)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, request.Password))
            {
                throw new UnauthorizedAccessException("Invalid email or password");
            }

            var token = _tokenService.GenerateJwtToken(user);

            var response = _mapper.Map<LoginResponse>(user);
            response.Token = token;

            return response;
        }
    }
}
