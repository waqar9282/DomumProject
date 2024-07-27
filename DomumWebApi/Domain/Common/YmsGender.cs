using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("Yms_Gender")]
public partial class YmsGender
{
    [Column("GId")]
    public int Gid { get; set; }

    [Column("GName")]
    [StringLength(50)]
    public string? Gname { get; set; }

    [StringLength(50)]
    public string? IsActive { get; set; }

    [Column("GCreateDate", TypeName = "datetime")]
    public DateTime? GcreateDate { get; set; }
}
