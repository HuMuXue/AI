/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹IOfficeRepository编写接口
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Extensions.AutofacManager;
namespace VoL.Domain.IRepositories
{
    /// <summary>
    /// 获取科室树形结构接口
    /// </summary>
    public partial interface IOfficeRepository : IDependency,IRepository<Office>
    {
        /// <summary>
        /// 获取科室树形结构数据
        /// </summary>
        /// <returns>包含树形结构的科室列表，每个科室节点包含子节点集合</returns>
        Task<List<Office>> GetOfficeTree();
    }
}
