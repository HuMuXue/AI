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
    [Entity(TableCnName = "撒户卡消毒列表",TableName = "PorterWorkDetail")]
    public partial class PorterWorkDetail:BaseEntity
    {
        /// <summary>
       ///主键id
       /// </summary>
       [Key]
       [Display(Name ="主键id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///护工id
       /// </summary>
       [Display(Name ="护工id")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PorterId { get; set; }

       /// <summary>
       ///病房id
       /// </summary>
       [Display(Name ="病房id")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WardId { get; set; }

       /// <summary>
       ///病区id
       /// </summary>
       [Display(Name ="病区id")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WardAreaId { get; set; }

       /// <summary>
       ///床位id
       /// </summary>
       [Display(Name ="床位id")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? BedId { get; set; }

       /// <summary>
       ///更换床单
       /// </summary>
       [Display(Name ="更换床单")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ReplaceBedSheet { get; set; }

       /// <summary>
       ///更换被褥
       /// </summary>
       [Display(Name ="更换被褥")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ReplaceBedding { get; set; }

       /// <summary>
       ///消毒液擦拭床头柜
       /// </summary>
       [Display(Name ="消毒液擦拭床头柜")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Disinfect { get; set; }

       /// <summary>
       ///枕头紫外线照射
       /// </summary>
       [Display(Name ="枕头紫外线照射")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Emit { get; set; }

       /// <summary>
       ///更换床垫
       /// </summary>
       [Display(Name ="更换床垫")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ReplaceMattress { get; set; }

       /// <summary>
       ///出院消毒
       /// </summary>
       [Display(Name ="出院消毒")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OutDisinfect { get; set; }

       /// <summary>
       ///时间
       /// </summary>
       [Display(Name ="时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime WorkTime { get; set; }

       
    }
}