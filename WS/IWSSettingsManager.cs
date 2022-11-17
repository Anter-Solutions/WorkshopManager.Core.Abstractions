using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Common.WS;

namespace WorkshopManager.Core.Abstractions.WS
{
    public interface IWSSettingsManager
    {
        Task<WSSettings> Get();
        Task Update(WSSettings wss);
    }
}
