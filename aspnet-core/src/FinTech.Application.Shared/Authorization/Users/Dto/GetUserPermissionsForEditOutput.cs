﻿using System.Collections.Generic;
using FinTech.Authorization.Permissions.Dto;

namespace FinTech.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}