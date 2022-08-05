﻿using DTOLibrary.UserDto;
using DTOLibrary.UserDto.Login;

namespace AuthService.Services;

public interface IAuthService
{
    Task<UserResponse> RegisterUserAsync(CreateUserRequest createUserRequest);
    
    Task<LoginResponse> LoginUserAsync(LoginRequest loginRequest); 
}