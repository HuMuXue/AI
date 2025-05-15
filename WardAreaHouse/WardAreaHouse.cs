/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "病区病房关联表",TableName = "WardAreaHouse")]
    public partial class WardAreaHouse:BaseEntity
    {
        /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///病区编号
       /// </summary>
       [Display(Name ="病区编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WardAreaId { get; set; }

       /// <summary>
       ///病房编号
       /// </summary>
       [Display(Name ="病房编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WardId { get; set; }

       
    }
}