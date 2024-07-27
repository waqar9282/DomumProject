using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("ItemsSSD")]
public partial class ItemsSsd
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(250)]
    public string? Items { get; set; }

    [Column("isactive")]
    public bool? Isactive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
