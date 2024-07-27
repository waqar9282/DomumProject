using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
public partial class ObjRemark
{
    [Column("sr")]
    public int Sr { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Objection { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Typ { get; set; }

    [Column("DT", TypeName = "datetime")]
    public DateTime? Dt { get; set; }
}
