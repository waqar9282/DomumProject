using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("statehsd")]
public partial class Statehsd
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? State { get; set; }

    [Column("isactive")]
    public bool? Isactive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
