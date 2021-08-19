using Abp.Authorization;
using FinTech.Authorization.Roles;
using FinTech.Authorization.Users;

namespace FinTech.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
