using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("Spdietary")]
public partial class Spdietary
{
    public int Id { get; set; }

    [Column("Special_Dietary")]
    [StringLength(500)]
    public string? SpecialDietary { get; set; }

    public bool? IsActive { get; set; }

    [Column("timestamp", TypeName = "datetime")]
    public DateTime? Timestamp { get; set; }
}
