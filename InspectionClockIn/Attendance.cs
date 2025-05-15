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
    [Entity(TableCnName = "打卡维护",TableName = "Attendance")]
    public partial class Attendance:BaseEntity
    {
        /// <summary>
       ///Id
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///巡查人姓名
       /// </summary>
       [Display(Name ="巡查人姓名")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string PatrolName { get; set; }

       /// <summary>
       ///病区Id
       /// </summary>
       [Display(Name ="病区Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WardAreaId { get; set; }

       /// <summary>
       ///病房Id
       /// </summary>
       [Display(Name ="病房Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WardId { get; set; }

       /// <summary>
       ///床位Id
       /// </summary>
       [Display(Name ="床位Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int BedId { get; set; }

       /// <summary>
       ///巡查日期
       /// </summary>
       [Display(Name ="巡查日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime PatrolTime { get; set; }

       
    }
}