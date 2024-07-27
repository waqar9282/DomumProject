using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("YMSAccesslevel")]
public partial class Ymsaccesslevel
{
    [Column("AId")]
    public int Aid { get; set; }

    [StringLength(150)]
    public string? AccessName { get; set; }

    [StringLength(150)]
    public string? AccessType { get; set; }

    public bool? IsActive { get; set; }

    [Column("ACreatedate", TypeName = "datetime")]
    public DateTime? Acreatedate { get; set; }
}
