/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹NursingUnitWardController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VoL.Domain.IServices;
namespace VoL.Domain.Controllers
{
    [Route("api/NursingUnitWard")]
    [PermissionTable(Name = "NursingUnitWard")]
    public partial class NursingUnitWardController : ApiBaseController<INursingUnitWardService>
    {
        public NursingUnitWardController(INursingUnitWardService service)
        : base(service)
        {
        }
    }
}

