using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("Gender")]
public partial class Gender
{
    public int Id { get; set; }

    [Column("Gender")]
    [StringLength(50)]
    public string? Gender1 { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createdate { get; set; }
}
