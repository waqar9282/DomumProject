using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("HSDocument")]
public partial class Hsdocument
{
    public int Id { get; set; }

    [StringLength(350)]
    public string? Itemschecked { get; set; }

    [StringLength(350)]
    public string? Location { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EventDate { get; set; }

    public TimeOnly? Eventtime { get; set; }

    [StringLength(550)]
    public string? Remarks { get; set; }

    [StringLength(250)]
    public string? State { get; set; }

    [StringLength(550)]
    public string? Pic { get; set; }

    [StringLength(150)]
    public string? CreatedBy { get; set; }

    [Column("locationid")]
    public int? Locationid { get; set; }

    [Column("isactive")]
    public bool Isactive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }
}
