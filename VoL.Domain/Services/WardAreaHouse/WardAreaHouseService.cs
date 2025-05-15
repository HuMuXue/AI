/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下WardAreaHouseService与IWardAreaHouseService中编写
 */
using VoL.Domain.IRepositories;
using VoL.Domain.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VoL.Domain.Services
{
    public partial class WardAreaHouseService : ServiceBase<WardAreaHouse, IWardAreaHouseRepository>
    , IWardAreaHouseService, IDependency
    {
    public static IWardAreaHouseService Instance
    {
      get { return AutofacContainerModule.GetService<IWardAreaHouseService>(); } }
    }
 }
