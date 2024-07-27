using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("logtypetablesname")]
public partial class Logtypetablesname
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(500)]
    public string? TableName { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    public bool? Status { get; set; }

    [Column("createddate", TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
