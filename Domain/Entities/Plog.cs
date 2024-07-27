using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("PLog")]
public partial class Plog
{
    public int Id { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    public bool? Status { get; set; }

    [Column("createddate", TypeName = "datetime")]
    public DateTime Createddate { get; set; }
}
