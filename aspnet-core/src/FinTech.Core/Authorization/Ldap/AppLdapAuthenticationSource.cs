using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using FinTech.Authorization.Users;
using FinTech.MultiTenancy;

namespace FinTech.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}