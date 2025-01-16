using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UGame.Quartz.Service.Services.Activity.InviteNewuser;
using UGame.Quartz.Service.Services.ClearData;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class ClearDataController : QuartzControllerBase
    {

        private ClearDataService _clearDataService = new();

        [HttpPost]
        [AllowAnonymous]
        public async Task<string> Clear()
        {
            return await _clearDataService.Execute();
        }

    }
}
