/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹PorterWorkDetailRepository编写代码
 */
using VoL.Domain.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VoL.Domain.Repositories
{
    public partial class PorterWorkDetailRepository : RepositoryBase<PorterWorkDetail> , IPorterWorkDetailRepository
    {
    public PorterWorkDetailRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IPorterWorkDetailRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IPorterWorkDetailRepository>(); } }
    }
}
