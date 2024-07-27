using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("Usr_Log")]
public partial class UsrLog
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Activity { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ip { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Unm { get; set; }

    [Column("DT", TypeName = "datetime")]
    public DateTime? Dt { get; set; }
}
