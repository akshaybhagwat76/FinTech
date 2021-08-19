using System.Collections.Generic;
using FinTech.Auditing.Dto;
using FinTech.Dto;

namespace FinTech.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
