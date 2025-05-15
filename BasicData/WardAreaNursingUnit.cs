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
    [Entity(TableCnName = "病区护理单元分配",TableName = "WardAreaNursingUnit")]
    public partial class WardAreaNursingUnit:BaseEntity
    {
        /// <summary>
       ///主键Id
       /// </summary>
       [Key]
       [Display(Name ="主键Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///病区编号
       /// </summary>
       [Display(Name ="病区编号")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WardAreaCode { get; set; }

       /// <summary>
       ///护理单元编号
       /// </summary>
       [Display(Name ="护理单元编号")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string NursingUnit { get; set; }

       /// <summary>
       ///护士编号
       /// </summary>
       [Display(Name ="护士编号")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string NurseCode { get; set; }

       
    }
}