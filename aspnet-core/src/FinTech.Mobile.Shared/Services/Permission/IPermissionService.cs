﻿namespace FinTech.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}