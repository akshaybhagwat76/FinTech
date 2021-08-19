﻿using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using FinTech.Authorization.Users.Dto;
using FinTech.Authorization.Users.Profile.Dto;
using FinTech.Dto;

namespace FinTech.Authorization.Users.Profile
{
    public interface IProfileAppService : IApplicationService
    {
        Task<CurrentUserProfileEditDto> GetCurrentUserProfileForEdit();

        Task UpdateCurrentUserProfile(CurrentUserProfileEditDto input);

        Task ChangePassword(ChangePasswordInput input);

        Task UpdateProfilePicture(UpdateProfilePictureInput input);

        Task<GetPasswordComplexitySettingOutput> GetPasswordComplexitySetting();

        Task<GetProfilePictureOutput> GetProfilePicture();

        Task<GetProfilePictureOutput> GetProfilePictureByUser(long userId);
        
        Task<GetProfilePictureOutput> GetProfilePictureByUserName(string username);

        Task<GetProfilePictureOutput> GetFriendProfilePicture(GetFriendProfilePictureInput input);

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<UpdateGoogleAuthenticatorKeyOutput> UpdateGoogleAuthenticatorKey();

        Task SendVerificationSms(SendVerificationSmsInputDto input);

        Task VerifySmsCode(VerifySmsCodeInputDto input);

        Task PrepareCollectedData();
    }
}
