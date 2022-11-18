using WorkshopManager.Common.WS;

namespace WorkshopManager.Core.Abstractions.WS
{
    public interface IWSSettingsManager
    {
        Task<WSSettings> Get();
        Task Update(WSSettings wss);
    }
}
