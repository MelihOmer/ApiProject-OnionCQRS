﻿using ApiProject.Application.Bases;
using ApiProject.Application.Features.Auth.Exceptions;
using ApiProject.Domain.Entities;

namespace ApiProject.Application.Features.Auth.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user is not null) throw new UserAlreadyExistException();
            return Task.CompletedTask;
        }
        public Task EmailOrPasswordShouldNotBeInvalid(User? user, bool checkPassword)
        {
            if (user is null || !checkPassword)
                throw new EmailOrPasswordShouldNotBeInvalidException();
            return Task.CompletedTask;
        }
        public Task RefreshTokenShouldNotBeExpired(DateTime? refreshTokenExpiryTime)
        {
            if (refreshTokenExpiryTime <= DateTime.Now)
                throw new RefreshTokenShouldNotBeExpiredException();
            return Task.CompletedTask;
        }

        public Task EmailAddressShouldBeValid(User? user)
        {
            if (user is null)
                throw new EmailAddressShouldBeValidException();
            return Task.CompletedTask;
        }
    }
}
