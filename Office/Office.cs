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
    [Entity(TableCnName = "科室表",TableName = "Office")]
    public partial class Office:BaseEntity
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
       ///上级部门
       /// </summary>
       [Display(Name ="上级部门")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentDepart { get; set; }

       /// <summary>
       ///科室编号
       /// </summary>
       [Display(Name ="科室编号")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string OfficeCode { get; set; }

       /// <summary>
       ///科室名称
       /// </summary>
       [Display(Name ="科室名称")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string OfficeName { get; set; }

       
    }
}