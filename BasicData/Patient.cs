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
    [Entity(TableCnName = "患者表",TableName = "Patient")]
    public partial class Patient:BaseEntity
    {
        /// <summary>
       ///主键编号
       /// </summary>
       [Key]
       [Display(Name ="主键编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///患者编号
       /// </summary>
       [Display(Name ="患者编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string PatientCode { get; set; }

       /// <summary>
       ///姓名
       /// </summary>
       [Display(Name ="姓名")]
       [MaxLength(30)]
       [Column(TypeName="varchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Name { get; set; }

       /// <summary>
       ///科室编号
       /// </summary>
       [Display(Name ="科室编号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string OfficeCode { get; set; }

       /// <summary>
       ///病区编号
       /// </summary>
       [Display(Name ="病区编号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WardAreaCode { get; set; }

       /// <summary>
       ///护理单元
       /// </summary>
       [Display(Name ="护理单元")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string NursingUnit { get; set; }

       /// <summary>
       ///病房编号
       /// </summary>
       [Display(Name ="病房编号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WardCode { get; set; }

       /// <summary>
       ///床位编号
       /// </summary>
       [Display(Name ="床位编号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string BedCode { get; set; }

       /// <summary>
       ///性别
       /// </summary>
       [Display(Name ="性别")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sex { get; set; }

       /// <summary>
       ///年龄
       /// </summary>
       [Display(Name ="年龄")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Age { get; set; }

       /// <summary>
       ///身份证号码
       /// </summary>
       [Display(Name ="身份证号码")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string IDNo { get; set; }

       /// <summary>
       ///手机号
       /// </summary>
       [Display(Name ="手机号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Phone { get; set; }

       /// <summary>
       ///住址
       /// </summary>
       [Display(Name ="住址")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Address { get; set; }

       /// <summary>
       ///紧急联系人
       /// </summary>
       [Display(Name ="紧急联系人")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string SOSName { get; set; }

       /// <summary>
       ///诊断内容
       /// </summary>
       [Display(Name ="诊断内容")]
       [MaxLength(2000)]
       [Column(TypeName="varchar(2000)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Diagnosis { get; set; }

       
    }
}