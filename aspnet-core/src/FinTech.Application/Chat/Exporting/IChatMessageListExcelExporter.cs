using System.Collections.Generic;
using Abp;
using FinTech.Chat.Dto;
using FinTech.Dto;

namespace FinTech.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
