﻿using My_App.Domain.Users;

namespace My_App.Application.Core.Abstractions.Authentication;

public interface IJwtProvider
{
    string GenerateToken(User user);
}
