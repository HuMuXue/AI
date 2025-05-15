using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using VOL.Core.EFDbContext;

/// <summary>
/// 包含领域层基础设施相关的实现，提供数据访问等基础操作的具体实现。
/// </summary>
namespace VoL.Domain.Infrastructure
{
    /// <summary>
    /// 实现基本数据仓储操作的泛型类，为实体提供通用的数据访问方法的具体实现。
    /// </summary>
    /// <typeparam name="T">泛型实体类型，约束为类类型。</typeparam>
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        /// <summary>
        /// 数据库上下文实例
        /// </summary>
        VOLContext db;
        /// <summary>
        /// 初始化 <see cref="BaseRepository{T}"/> 实例。
        /// </summary>
        /// <param name="db">数据库上下文实例，用于执行数据操作（如增删改查）。</param>
        public BaseRepository(VOLContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// 插入实体到数据库
        /// </summary>
        /// <param name="t">要插入的实体对象</param>
        /// <returns>受影响的行数</returns>
        public async Task<int> Add(T t)
        {
            await db.Set<T>().AddAsync(t);
            return await db.SaveChangesAsync();
        }

        /// <summary>
        /// 更新数据库中的实体
        /// </summary>
        /// <param name="t">包含更新数据的实体对象</param>
        /// <returns>受影响的行数</returns>
        public async Task<int> Update(T t)
        {
            db.Set<T>().Update(t);
            return await db.SaveChangesAsync();
        }

        /// <summary>
        /// 从数据库删除实体
        /// </summary>
        /// <param name="t">要删除的实体对象</param>
        /// <returns>受影响的行数</returns>
        public async Task<int> Delete(T t)
        {
            db.Set<T>().Remove(t);
            return await db.SaveChangesAsync();
        }

        /// <summary>
        /// 获取实体集合的查询接口
        /// </summary>
        /// <returns>可查询的实体集合</returns>
        public IQueryable<T> GetAll()
        {
            return db.Set<T>().AsQueryable();
        }
    }
}
