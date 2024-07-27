using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("Keyworkingsessiontype")]
public partial class Keyworkingsessiontype
{
    public int Id { get; set; }

    [StringLength(150)]
    public string? Type { get; set; }

    public bool? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }
}
