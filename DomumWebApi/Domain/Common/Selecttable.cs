using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("Selecttable")]
public partial class Selecttable
{
    public int Id { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    public bool? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
