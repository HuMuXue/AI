using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using VoL.Domain.Infrastructure;
using VoL.Domain.IRepositories;
using VoL.Domain.IServices.BasicData.Partial;
using VOL.Entity.DomainModels;

namespace VoL.Domain.Services.BasicData.Partial
{
    public class NursingUnitWardServices: INursingUnitWardServices
    {
        IBaseRepository<NursingUnitWard> nursingRep;

        public NursingUnitWardServices(IBaseRepository<NursingUnitWard> nursingRep)
        {
            this.nursingRep = nursingRep;
        }

        public List<NursingUnitWard> GetNursing()
        {
            return nursingRep.GetAll().ToList();
        }
    }                                 
}
