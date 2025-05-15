using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 包含领域层基础设施相关的接口定义，提供数据访问等基础操作的抽象。
/// </summary>
namespace VoL.Domain.Infrastructure
{
    /// <summary>
    /// 定义基本数据仓储操作的泛型接口，为实体提供通用的数据访问方法。
    /// </summary>
    /// <typeparam name="T">泛型实体类型，约束为类类型。</typeparam>
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// 插入实体到数据库
        /// </summary>
        /// <param name="t">要插入的实体对象</param>
        /// <returns>受影响的行数</returns>
        Task<int> Add(T t);

        /// <summary>
        /// 更新数据库中的实体
        /// </summary>
        /// <param name="t">包含更新数据的实体对象</param>
        /// <returns>受影响的行数</returns>
        Task<int> Update(T t);

        /// <summary>
        /// 从数据库删除实体
        /// </summary>
        /// <param name="t">要删除的实体对象</param>
        /// <returns>受影响的行数</returns>
        Task<int> Delete(T t);

        /// <summary>
        /// 获取实体集合的查询接口
        /// </summary>
        /// <returns>可查询的实体集合</returns>
        IQueryable<T> GetAll();
    }
}
