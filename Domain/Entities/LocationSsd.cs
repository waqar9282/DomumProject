using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("LocationSSD")]
public partial class LocationSsd
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(150)]
    public string? Location { get; set; }

    [Column("isactive")]
    public bool? Isactive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
