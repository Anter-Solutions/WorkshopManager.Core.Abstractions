using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.Core.Abstractions.Controllers
{
    [Authorize]
    [ApiController]
    public class ProtectedApiControllerBase : ControllerBase
    {
    }
}
