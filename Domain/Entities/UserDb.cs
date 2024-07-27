using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("user_db")]
public partial class UserDb
{
    [Column("id")]
    public int Id { get; set; }

    [Column("username")]
    [StringLength(50)]
    public string? Username { get; set; }

    [Column("accesslevel")]
    public int? Accesslevel { get; set; }

    [Column("DOB", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [StringLength(50)]
    public string? Contact { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(150)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("pswrd")]
    [StringLength(50)]
    public string? Pswrd { get; set; }

    [StringLength(550)]
    public string? LicenseNo { get; set; }

    [Column("Inst_Code")]
    [StringLength(50)]
    public string? InstCode { get; set; }

    [StringLength(150)]
    public string? Dept { get; set; }

    public bool? Comm { get; set; }

    [Column("LFlag")]
    public bool? Lflag { get; set; }

    [StringLength(550)]
    public string? LocalAuthorityName { get; set; }

    [StringLength(50)]
    public string? Landline { get; set; }

    [StringLength(550)]
    public string? Pic { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
