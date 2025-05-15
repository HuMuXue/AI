using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.DomainModels;

namespace VoL.Domain.IServices.BasicData.Partial
{
    /// <summary>
    /// 接口
    /// </summary>
    public interface INursingUnitWardServices
    {
        List<NursingUnitWard> GetNursing();
    }
}
