using Abp.Auditing;
using FinTech.Configuration.Dto;

namespace FinTech.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}