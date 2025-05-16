using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoL.Domain.IServices.BasicData.Partial;
using VOL.Entity.DomainModels;

namespace VOL.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManagementController : ControllerBase
    {
        private readonly INursingUnitWardServices nursing;

        public ManagementController(INursingUnitWardServices nursing)
        {
            this.nursing = nursing;
        }

        [HttpGet]
        public List<NursingUnitWard> GetNursing()
        {
            return nursing.GetNursing();
        }
    }
}
