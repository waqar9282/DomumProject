using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Table("User_dbb")]
public partial class UserDbb
{
    [Key]
    public int Eid { get; set; }

    [Column("username")]
    [StringLength(250)]
    public string? Username { get; set; }

    [StringLength(50)]
    public string? Gender { get; set; }

    [Column("accesslevel")]
    public int? Accesslevel { get; set; }

    [StringLength(250)]
    public string? Contact { get; set; }

    [Column("email_id")]
    [StringLength(250)]
    public string? EmailId { get; set; }

    [StringLength(250)]
    public string? Status { get; set; }

    [StringLength(250)]
    public string? Uname { get; set; }

    [Column("pswrd")]
    [StringLength(250)]
    public string? Pswrd { get; set; }

    [Column("Inst_Code")]
    [StringLength(250)]
    public string? InstCode { get; set; }

    [StringLength(150)]
    public string? Dept { get; set; }

    public bool? Comm { get; set; }

    [Column("LFlag")]
    public bool? Lflag { get; set; }

    public bool? Active { get; set; }

    [Column("Created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }
}
