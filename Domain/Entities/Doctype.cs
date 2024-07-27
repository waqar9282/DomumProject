using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("doctype")]
public partial class Doctype
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [Column("isactive")]
    public bool? Isactive { get; set; }
}
