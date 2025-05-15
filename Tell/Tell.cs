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
    [Entity(TableCnName = "医嘱表",TableName = "Tell")]
    public partial class Tell:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DoctorCode")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string DoctorCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BedCode")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string BedCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PatientCode")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string PatientCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DoctorContent")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string DoctorContent { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DoctorSTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime DoctorSTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DoctorETime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? DoctorETime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IsPublisher")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int IsPublisher { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IsDelete")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int IsDelete { get; set; }

       
    }
}